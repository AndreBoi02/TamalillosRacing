using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    public LapManager lapManager;

    private void Start()
    {
        lapManager = GameObject.Find("Managers").GetComponent<LapManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!lapManager.raceFinished)
        {
            if (other.tag == "Player" || other.tag == "Car2")
            {
                lapManager.AdvanceTrigger();
                Debug.Log(other.tag);
            }
        }
        else
        {
            lapManager.PlayerWins(other.tag);
        }
    }
}
