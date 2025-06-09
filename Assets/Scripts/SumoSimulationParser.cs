using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.IO.Compression;

using UnityEngine;
using TMPro;

using Eclipse.Sumo.Libsumo;
// using Eclipse.Sumo.Libtraci;

public class SumoSimulationParser : MonoBehaviour
{
    static public TextMeshProUGUI uiText;
    static List<(double, double)[]> positions;
    static string simulationName;
    static string simulationPath;

    public List<(double, double)[]> Parse(string simulationName)
    {
        SumoSimulationParser.simulationName = simulationName;
        simulationPath = Path.Combine(Application.persistentDataPath, "SumoOutput", simulationName, "osm.sumocfg");
        positions = new List<(double, double)[]>();
        ReadSimulation();
        return positions;
    }

    // Starts a python script to read the given simulation
    static void ReadSimulation()
    {
        // Update UI
        UnityEngine.Debug.Log("Reading simulation ...");

        UnityEngine.Debug.Log("Persistent Data Path: " + Application.persistentDataPath);

        // Parse passenger.trips.xml to retreive the number of vehicles
        XmlDocument passengerTrips = new XmlDocument();
        passengerTrips.Load(Path.Combine(Application.persistentDataPath, "SumoOutput", simulationName, "osm.passenger.trips.xml"));
        XmlElement root = passengerTrips.DocumentElement;
        XmlNodeList tripNodes = passengerTrips.GetElementsByTagName("trip");
        int numberOfVehicles = tripNodes.Count;

        // Start simulation
        Simulation.start(new StringVector(new string[] { "sumo", "-c", simulationPath }));

        int step = 0;

        // Run through simulation and fill positions List with data
        while (Simulation.getMinExpectedNumber() > 0)
        {
            (double, double)[] stepPositions = new (double, double)[numberOfVehicles];
            foreach (string vehId in Simulation.getLoadedIDList())
            {
                int vehIdNumber = int.Parse(vehId.Split("veh")[1]);
                double x_pos = Vehicle.getPosition(vehId).x;
                double y_pos = Vehicle.getPosition(vehId).y;
                stepPositions[vehIdNumber] = (x_pos, y_pos);
                UnityEngine.Debug.Log($"Step {step}, vehicle {vehId} has position ({x_pos}, {y_pos}) ({Simulation.getLoadedNumber()} loaded cars)");
            }
            positions.Add(stepPositions);
            Simulation.step();
            step++;
        }
        
        Simulation.close();
    }
}
