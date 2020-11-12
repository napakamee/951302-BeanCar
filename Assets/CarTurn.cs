using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ConstantForce))]
public class CarTurn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    KeyCode _keyLeft;
    [SerializeField]
    KeyCode _keyRight;
    [SerializeField]
    KeyCode _keyFront;
    [SerializeField]
    KeyCode _keyBack;
    public KeyCode KeyLeft { get => _keyLeft; set => _keyLeft = value; }
    public KeyCode KeyRight { get => _keyRight; set => _keyRight = value; }
    public KeyCode KeyFront { get => _keyFront; set => _keyFront = value; }
    public KeyCode KeyBack { get => _keyBack; set => _keyBack = value; }
    public float turnForce = 1000;
    public float moveForce = 80;
    public float backForce = 50;

    ConstantForce _constantForceComponent;
    Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = this.GetComponent<Transform>();
        _constantForceComponent = this.GetComponent<ConstantForce>();
        _constantForceComponent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyLeft))
        {
            _constantForceComponent.enabled = true;
            _constantForceComponent.torque = new Vector3(0, -turnForce, 0);
        }
        else if (Input.GetKey(KeyRight))
        {
            _constantForceComponent.enabled = true;
            _constantForceComponent.torque = new Vector3(0, turnForce, 0);
        }
        else if(Input.GetKey(KeyFront)){
            _constantForceComponent.enabled = true;
            _constantForceComponent.relativeForce = new Vector3(0,0, moveForce);
        }
        else if(Input.GetKey(KeyBack)){
            _constantForceComponent.enabled = true;
            _constantForceComponent.relativeForce = new Vector3(0,0, -backForce);
        }
        else
        {
            _constantForceComponent.enabled = false;

        }
    }
}
