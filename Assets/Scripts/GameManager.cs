using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Will be fetched dynamically in future
    // TODO
    string simulationName = "2025-05-06-18-46-49";
    List<(double, double)[]> positions;
    public SumoSimulationParser simParser;
    public CarManager carManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positions = simParser.Parse(simulationName);
        // carManager.StartSimulation(positions);
    }
}
