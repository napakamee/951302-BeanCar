
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
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
                    Debug.Log("player1dead"); GameManager.playerWin = 2; break;
                case PlayerType.Player2:
                    Debug.Log("player2dead"); GameManager.playerWin = 1; break;
            }
        }

    }

     void OnCollisionEnter(Collision collisionInfo)
    {
        PlayerScript Type = collisionInfo.gameObject.GetComponent<PlayerScript>();
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            switch (Type.playerType)
            {
                case PlayerType.Player1:
                    Debug.Log("player1dead"); GameManager.playerWin = 2; break;
                case PlayerType.Player2:
                    Debug.Log("player2dead"); GameManager.playerWin = 1; break;
            }
        }
    }
}
