using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarScript : MonoBehaviour
{
    [SerializeField] public Transform[] bulletLauncherPosition;
    [SerializeField]
    KeyCode _keyShoot;
    public Text bulletAmount;
    public KeyCode KeyShoot { get => _keyShoot; set => _keyShoot = value; }
    [SerializeField] public float bulletForceMagnitude = 30;
    [SerializeField] public GameObject _ball;
    float coolDown = 2;
    public int bulletNumber;
    // Start is called before the first frame update
    void Start()
    {
        bulletNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyShoot))
        {
            if (bulletNumber >= 1)
            {
                BallSpawn();
                bulletNumber--;
            }
        }

        bulletAmount.text = "Bullet Amount: " + bulletNumber;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            bulletNumber++;
            Destroy(other.gameObject);
        }
    }
    void BallSpawn()
    {
        int randPos;
        randPos = Random.Range(0, bulletLauncherPosition.Length);
        GameObject ball = Instantiate(_ball, bulletLauncherPosition[randPos]) as GameObject;
        //ball.transform.localScale = new Vector3(0.2f,0.2f,0.2f);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.AddForce(bulletLauncherPosition[randPos].forward * bulletForceMagnitude, ForceMode.Impulse);
        Destroy(ball, 2);
    }
}
