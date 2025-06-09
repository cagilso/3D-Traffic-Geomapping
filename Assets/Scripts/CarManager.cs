using UnityEngine;
using System.Collections.Generic;

public class CarManager : MonoBehaviour
{
    static List<GameObject> entities = new List<GameObject>();
    public GameObject carPrefab;
    private bool carsLoaded = false;
    private int step = 0;
    private List<(double, double)[]> positions;

    void Update()
    {
        if (!carsLoaded)
            return;

        if (step > positions.Count)
            return;

        for (int vehId = 0; vehId < positions[step].Length; vehId++)
        {
            float x_pos = (float) positions[step][vehId].Item1;
            float y_pos = (float) 0.5;
            float z_pos = (float) positions[step][vehId].Item2;
            entities[vehId].transform.position = new Vector3(x_pos, y_pos, z_pos);

            if (!(x_pos == 0) && !(z_pos == 0))
                UnityEngine.Debug.Log($"Step {step}, vehicle {vehId}: ({x_pos}, {z_pos})");
        }

        step++;
    }

    public void StartSimulation(List<(double, double)[]> positions)
    {

        this.positions = positions;
        int numberOfCars = positions[0].Length;
        UnityEngine.Debug.Log($"Number of cars: {numberOfCars}");

        for (int i = 0; i < numberOfCars; i++)
        {
            entities.Add(Instantiate(carPrefab, new Vector3(0, 0, 0), Quaternion.identity));
        }

        carsLoaded = true;
        UnityEngine.Debug.Log($"Cars loaded");
    }
}
