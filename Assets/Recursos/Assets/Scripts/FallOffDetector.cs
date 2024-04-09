using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOffDetector : MonoBehaviour
{
    public LapManager lapManager;

    private void Start()
    {
        lapManager = GameObject.Find("Managers").GetComponent<LapManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lapManager.PlayerWins("Car2");
            Debug.Log("detectao1");
        }
        else if (other.tag == "Car2")
        {
            lapManager.PlayerWins("Player");
            Debug.Log("detectao2");
        }
    }
}
