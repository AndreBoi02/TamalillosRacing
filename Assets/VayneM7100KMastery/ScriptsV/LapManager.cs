using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LapManager : MonoBehaviour
{
    public GameObject[] lapsTriggers;
    public GameObject winCanvas;
    public TextMeshProUGUI winText;
    private int currentTrigger = 0;
    public int lapCounter;
    public bool raceFinished = false;

    private void Start()
    {
        for (int i = 0; i < lapsTriggers.Length; i++)
        {
            lapsTriggers[i].SetActive(i == 0);
        }
        winCanvas.SetActive(false);
    }

    private void Update()
    {
        if (lapCounter >= 9 && !raceFinished)
        {
            Debug.Log("Race Finished");
            raceFinished = true;
        }
    }

    public void AdvanceTrigger()
    {
        lapsTriggers[currentTrigger].SetActive(false);
        lapCounter++;
        currentTrigger = (currentTrigger + 1) % lapsTriggers.Length;
        lapsTriggers[currentTrigger].SetActive(true);
    }

    public void PlayerWins(string playerTag)
    {
        winCanvas.SetActive(true);
        winText.text = playerTag == "Player" ? "¡Jugador 1 gana la carrera!" : "¡Jugador 2 gana la carrera!";
        raceFinished = true;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
