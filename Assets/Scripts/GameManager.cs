using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerWin;
    public GameObject Player1WinUI;
    public GameObject Player2WinUI;
    // Start is called before the first frame update
    void Start()
    {
        playerWin = 0;
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
        Player1WinUI.SetActive(true);
    }
    public void Player2Win()
    {
        Player2WinUI.SetActive(true);
    }

}
