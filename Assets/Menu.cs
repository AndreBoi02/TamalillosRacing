using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void Play() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credits() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Exit() {
        Debug.Log("Exit...");
        Application.Quit();
    }

    public void Back() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -2);
    }
}
