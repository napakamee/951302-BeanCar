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
    public AudioClip pew;
    public AudioClip quack;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(quack);
            Destroy(other.gameObject);
        }
    }
    void BallSpawn()
    {
        int randPos;
        audioSource.PlayOneShot(pew);
        randPos = Random.Range(0, bulletLauncherPosition.Length);
        GameObject ball = Instantiate(_ball, bulletLauncherPosition[randPos]) as GameObject;
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.AddForce(bulletLauncherPosition[randPos].forward * bulletForceMagnitude, ForceMode.Impulse);
        Destroy(ball, 2);
    }
}
