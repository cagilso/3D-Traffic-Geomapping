using UnityEngine;
using System.Collections.Generic;

public class CarManager : MonoBehaviour
{
    static List<GameObject> entities = new List<GameObject>();
    public GameObject carPrefab;
    private bool carsLoaded = false;
    private int step = 0;
    private (double, double)[,] positions;

    void Update()
    {
        if (!carsLoaded)
            return;

        if (step > positions.GetLength(0))
            return;

        for (int i = 0; i < positions.GetLength(1); i++)
        {
            entities[i].transform.position = new Vector3((float)positions[step, i].Item1, (float)0.5, (float)positions[step, i].Item2);

            if (!((float)positions[step, i].Item1 == 0) && !((float)positions[step, i].Item2 == 0))
                UnityEngine.Debug.Log($"Step {step}, vehicle {i}: ({(float)positions[step, i].Item1}, {(float)positions[step, i].Item2})");
        }

        step++;
    }

    public void StartSimulation((double, double)[,] positions)
    {

        this.positions = positions;

        int numberOfCars = positions.GetLength(1);
        UnityEngine.Debug.Log($"Number of cars: {numberOfCars}");

        for (int i = 0; i < numberOfCars; i++)
        {
            entities.Add(Instantiate(carPrefab, new Vector3(0, 0, 0), Quaternion.identity));
        }

        carsLoaded = true;
        UnityEngine.Debug.Log($"Cars loaded");
    }
}
