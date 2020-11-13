using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerScript Type = other.gameObject.GetComponent<PlayerScript>();
        if (other.gameObject.CompareTag("Player"))
        {
            switch (Type.playerType)
            {
                case PlayerType.Player1:
                     GameManager.playerWin = 1; break;
                case PlayerType.Player2:
                     GameManager.playerWin = 2; break;
            }
        }

    }
}
