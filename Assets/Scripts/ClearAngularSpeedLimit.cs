using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAngularSpeedLimit : MonoBehaviour
{
   [SerializeField]
    protected float _maxAngularSpeedLimit = float.PositiveInfinity;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.maxAngularVelocity = _maxAngularSpeedLimit;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaximumAngularSpeedLimit(float value) {
        _maxAngularSpeedLimit = value;
    }
}
