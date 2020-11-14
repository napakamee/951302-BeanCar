using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenemanager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip uiSound;
    public AudioClip clickSound;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void PlayUISound()
    {
        audioSource.PlayOneShot(uiSound);
    }
    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
