using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Collections;

using UnityEngine;
using TMPro;

public class SumoSimulationParser : MonoBehaviour
{
    static public TextMeshProUGUI uiText;
    static (double, double)[,] positions;
    static string simulationName;
    static string outputPath;

    public (double, double)[,] Parse(string simulationName)
    {
        SumoSimulationParser.simulationName = simulationName;
        outputPath = Path.Combine(Application.persistentDataPath, "SumoOutput", simulationName, "parser.output.xml");
        ReadSimulation();
        ReadOutput();
        return positions;
    }

    // Starts a python script to read the given simulation
    static void ReadSimulation()
    {
        // Update UI
        UnityEngine.Debug.Log("Reading simulation ...");
        
        UnityEngine.Debug.Log("Persistent Data Path: " + Application.persistentDataPath);

        // Paths
        string venvPythonExecutablePath = Path.Combine(Application.persistentDataPath, "win_venv", "Scripts", "python.exe");
        string pythonScriptToExecutePath = Path.Combine(Application.persistentDataPath, "SumoParserHelper.py");

        // Arguments for your SumoParserHelper.py script:
        // Ensure paths with spaces are quoted for command-line arguments.
        string scriptArguments = $"\"{pythonScriptToExecutePath}\" \"{Application.persistentDataPath}\" \"{simulationName}\"";

        // Ensure the Python executable path itself is quoted if it might contain spaces,
        // though typically Application.persistentDataPath doesn't have spaces unless the user's name does.
        // For safety, quoting it is good practice if passing directly to an OS process.
        // However, when setting ProcessStartInfo.FileName, quotes are often handled differently
        // or not needed if UseShellExecute is false. For direct executable paths, it's usually fine without.

        UnityEngine.Debug.Log($"Attempting to run: {venvPythonExecutablePath} with arguments: {scriptArguments}");
        
        // Create a new process to directly call the venv's python.exe
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = venvPythonExecutablePath, // Directly use the python.exe from your venv
            Arguments = scriptArguments,          // Pass your script and its arguments
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,              // Crucial: avoids shell interference
            CreateNoWindow = true
        };

        // Start the process
        Process process = new Process
        {
            StartInfo = startInfo
        };

        try
        {
            process.Start();

            // Best practice: Read output/error asynchronously or in a way that doesn't deadlock.
            // For simplicity, synchronous read is shown here, but consider async for long tasks.
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit(); // Wait for the process to complete

            if (!string.IsNullOrEmpty(error))
            {
                UnityEngine.Debug.LogError("Python script errors: " + error);
            }
            UnityEngine.Debug.Log("Python script output: " + output);
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogError($"Failed to start Python process: {ex.Message}");
            UnityEngine.Debug.LogError($"Attempted to run: {startInfo.FileName} {startInfo.Arguments}");
            // Log more details if needed, e.g., if the python.exe wasn't found
            if (!File.Exists(venvPythonExecutablePath))
            {
                UnityEngine.Debug.LogError($"Python executable not found at: {venvPythonExecutablePath}");
            }
        }
    }

    static void ReadOutput()
    {
        // Update UI
        UnityEngine.Debug.Log("Reading output ...");

        // Load XML document
        XmlDocument output = new XmlDocument();
        output.Load(outputPath);
        XmlElement root = output.DocumentElement;

        // Parse root information
        int numberOfSteps = int.Parse(root.Attributes["steps"].Value);
        int numberOfVehicles = int.Parse(root.Attributes["vehicles"].Value);

        // Create array of appropriate size
        positions = new (double, double)[numberOfSteps, numberOfVehicles];

        // Fill array with positional values from XML doc
        foreach (XmlNode step in root.ChildNodes)
        {
            int step_number = int.Parse(step.Attributes["id"].Value.Split("step")[1]);

            foreach (XmlNode vehicle in step.ChildNodes)
            {
                int vehicle_number = int.Parse(vehicle.Attributes["id"].Value.Split("veh")[1]);
                double x_pos = double.Parse(vehicle.Attributes["x_coordinate"].Value);
                double y_pos = double.Parse(vehicle.Attributes["y_coordinate"].Value);

                positions[step_number, vehicle_number] = (x_pos, y_pos);
            }
        }

        // Update UI
        UnityEngine.Debug.Log("Finished reading output!");
    }
}
