using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Start() {
        pauseMenu.SetActive(false);
        
    }

    void Awake()
    {
        
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }

        
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseGame() {
        pauseMenu.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;

    }  

    public void LoadMenu() {
        Debug.Log("Loading menu...");
    }
}
