using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject playerBody;
    public GameObject playerCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        playerCamera.transform.Rotate(Vector3.up, mouseX * rotationSpeed);
        playerCamera.transform.Rotate(-Vector3.right, mouseY * rotationSpeed);
        playerCamera.transform.rotation = Quaternion.Euler(
            playerCamera.transform.rotation.eulerAngles.x,
            playerCamera.transform.rotation.eulerAngles.y,
            0f
        );

    }
}
