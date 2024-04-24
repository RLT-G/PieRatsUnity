using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float HSpeed; public float VSpeed;
    public float rotationSpeed;
    public GameObject playerBody;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * HSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * VSpeed * Time.deltaTime;
        playerBody.transform.Translate(Vector3.forward * v);
        playerBody.transform.Translate(Vector3.right * h);

        float mouseX = Input.GetAxis("Mouse X");
        playerBody.transform.Rotate(Vector3.up, mouseX * rotationSpeed);
    }
}
