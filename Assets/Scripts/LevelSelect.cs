using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {
    
    public void ButtonMoveScene(int level) {
        SceneManager.LoadScene(level);
    }

    public void LoadMenu() {
        
        ButtonMoveScene(0);
    }

    public void LoadLevelSelect() {
        ButtonMoveScene(13);
    }

    public void LoadLevelOne() {
        ButtonMoveScene(1);
    }

    public void LoadLevelTwo() {
        ButtonMoveScene(2);
    }

    public void LoadLevelThree() {
        ButtonMoveScene(3);
    }

    public void LoadLevelFour() {
        ButtonMoveScene(4);
    }

    public void LoadLevelFive() {
        ButtonMoveScene(5);
    }
    public void LoadLevelSix() {
        ButtonMoveScene(6);
    }

    public void LoadLevelSeven() {
        ButtonMoveScene(7);
    }

    public void LoadLevelEight() {
        ButtonMoveScene(8);
    }

    public void LoadLevelNine() {
        ButtonMoveScene(9);
    }

    public void LoadLevelTen() {
        ButtonMoveScene(10);
    }

    public void LoadPP11() {
        ButtonMoveScene(11);
    }

    public void LoadPP12() {
        ButtonMoveScene(12);
    }
}
