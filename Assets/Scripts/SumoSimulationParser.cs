using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Collections;

using UnityEngine;
using TMPro;

public class SumoParser : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public (double, double)[,] positions;

    // Will be fetched dynamically in future
    // TODO
    string simulationName = "2025-05-06-18-46-49";
    string outputPath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        outputPath = Path.Combine(Application.persistentDataPath, "SumoOutput", simulationName, "parser.output.xml");
        uiText.SetText("Starting!");
        ReadSimulation();
        ReadOutput();
        uiText.text = "Finished!";
    }

    // Starts a python script to read the given simulation
    void ReadSimulation()
    {
        // Update UI
        UnityEngine.Debug.Log("Reading simulation ...");
        uiText.text = "Reading Simulation ...";
        
        UnityEngine.Debug.Log("Persistent Data Path: " + Application.persistentDataPath);

        // Create paths to call python script
        string pythonvenvPath = Path.Combine(Application.persistentDataPath, "win_venv", "Scripts", "activate.ps1");
        string pythonScriptPath = Path.Combine(Application.persistentDataPath, "SumoParserHelper.py");
        pythonvenvPath = $"\"{pythonvenvPath}\"";
        pythonScriptPath = $"\"{pythonScriptPath}\"";
        string scriptArguments = $"{pythonScriptPath} \"{Application.persistentDataPath}\" \"{simulationName}\"";

        // Create a new process
        ProcessStartInfo start = new ProcessStartInfo
        {
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            FileName = "powershell",
        };

        // Start the process
        var process = Process.Start(start);

        // Activate the python venv and execute the python script
        using var sw = process.StandardInput;
        if (sw.BaseStream.CanWrite)
        {
            sw.WriteLine($"& {pythonvenvPath}");
            sw.WriteLine($"python {scriptArguments}");
            sw.Flush();
            sw.Close();
        }

        // Log output and errors
        var output = process.StandardOutput.ReadToEnd();
        var error = process.StandardError.ReadToEnd();
        if (error != "")
        {
            UnityEngine.Debug.LogError("Python script errors: " + error);
        }
        UnityEngine.Debug.Log("Python script output: " + output);

        // Update UI
        UnityEngine.Debug.Log("Finished reading simulation!");
        uiText.text = "Finished reading simulation!";
    }

    void ReadOutput()
    {
        // Update UI
        UnityEngine.Debug.Log("Reading output ...");
        uiText.text = "Reading output ...";

        // Load XML document
        XmlDocument output = new XmlDocument();
        output.Load(outputPath);
        XmlElement root = output.DocumentElement;

        // Parse root information
        int numberOfSteps = int.Parse(root.Attributes["steps"].Value);
        int numberOfVehicles = int.Parse(root.Attributes["vehicles"].Value);

        // Create array of appropriate size
        (double, double)[,] positions = new (double, double)[numberOfSteps, numberOfVehicles];

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
        uiText.text = "Finished reading output!";
    }
}
