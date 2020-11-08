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
    public KeyCode KeyLeft { get => _keyLeft; set => _keyLeft = value; }
    public KeyCode KeyRight { get => _keyRight; set => _keyRight = value; }
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
            _constantForceComponent.torque = new Vector3(0, -1000 ,0);
        }
        else if (Input.GetKey(KeyRight)){
            _constantForceComponent.enabled = true;
            _constantForceComponent.torque = new Vector3(0, 1000, 0);
        }
        else
        {
            _constantForceComponent.enabled = false;
            
        }
    }
}
