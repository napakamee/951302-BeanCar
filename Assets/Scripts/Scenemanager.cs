using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanager : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("Gameplay");
    }
    public void Exit(){
        Application.Quit();
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
