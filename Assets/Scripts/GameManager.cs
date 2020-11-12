using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static int playerWin;
    public GameObject Player1WinUI;
    public GameObject Player2WinUI;
    // Start is called before the first frame update
    void Start()
    {
        playerWin = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerWin)
        {
            case 0:
                Player1WinUI.SetActive(false); Player2WinUI.SetActive(false); break;
            case 1:
                Player1Win(); break;
            case 2:
                Player2Win(); break;
        }
    }

    public void Player1Win()
    {
        Time.timeScale = 0;
        Player1WinUI.SetActive(true);
    }
    public void Player2Win()
    {
        Time.timeScale = 0;
        Player2WinUI.SetActive(true);
    }

    public void Restart(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
