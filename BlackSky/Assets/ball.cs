using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float mass;
    public float ballSpeed;
    // Start is called before the first frame update
    Rigidbody _rb;
    void Start()
    {
    _rb = GetComponent<Rigidbody>();
        _rb.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        _rb.AddForce(new Vector3(0, 0, 1) * ballSpeed);

        }
        
    }
}
