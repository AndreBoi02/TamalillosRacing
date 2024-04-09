using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    public GameObject[] lapsTriggers;
    private int currentTrigger = 0;
    public int lapCounter;
    public bool raceFinished = false;

    private void Start()
    {
        // Asegúrate de que solo el primer trigger esté activo al inicio
        for (int i = 0; i < lapsTriggers.Length; i++)
        {
            lapsTriggers[i].SetActive(i == 0);
        }
    }

    private void Update()
    {
        if (lapCounter >= 9)
        {
            Debug.Log("Race Finished");
            raceFinished = true;
        }
    }

    public void AdvanceTrigger()
    {
        // Desactiva el trigger actual
        lapsTriggers[currentTrigger].SetActive(false);

        // Hace un conteo cuando pasa por un trigger
        lapCounter++;

        // Avanza al siguiente trigger
        currentTrigger = (currentTrigger + 1) % lapsTriggers.Length;

        // Activa el siguiente trigger
        lapsTriggers[currentTrigger].SetActive(true);
    }
}
