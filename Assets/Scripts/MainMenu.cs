using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelect() {
        SceneManager.LoadScene(13);
    }

    public void quit() {
        Debug.Log ("has quit game");
        Application.Quit();
    }

    public void reverseReverse() {
        Debug.Log("hopefully restart level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
