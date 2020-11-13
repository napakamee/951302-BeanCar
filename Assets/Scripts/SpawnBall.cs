using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] public Transform[] bulletLauncherPosition;
    [SerializeField] public float bulletForceMagnitude = 30;
    [SerializeField] public GameObject _ball;
    public float nextTime = 1;
    float coolDown = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown <= 0){
            BallSpawn();
            coolDown = nextTime;
        }
    }

    void BallSpawn(){
        int randPos;
        randPos = Random.Range(0, bulletLauncherPosition.Length);
        GameObject ball = Instantiate(_ball, bulletLauncherPosition[randPos]) as GameObject;
        //ball.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.AddForce(bulletLauncherPosition[randPos].forward*bulletForceMagnitude,ForceMode.Impulse);
        Destroy(ball,5);
    }
}
