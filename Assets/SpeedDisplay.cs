using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedDisplay : MonoBehaviour
{
    private float speed;
    public Text speedTxt;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = (rb.velocity.magnitude) * 10f;

        speedTxt.text = "Speed: " + speed.ToString("F2");
    }
}
