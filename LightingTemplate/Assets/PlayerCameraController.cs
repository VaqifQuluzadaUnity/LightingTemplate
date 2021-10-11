using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private float horizontalSensitivity;

    [SerializeField] private float verticalSensitivity;

    [SerializeField] private Transform playerCamera;

    private float rotationX = 0;

    private float rotationY = 0;

    private void Update()
    {
        RotateCameraAndPlayer();
    }

    private void RotateCameraAndPlayer()
    {
        float rotationInputX = Input.GetAxis("Mouse X");

        float rotationInputY = Input.GetAxis("Mouse Y");

        rotationY += rotationInputX * Time.deltaTime * horizontalSensitivity;

        rotationX -= rotationInputY * Time.deltaTime * verticalSensitivity;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(transform.rotation.x,rotationY,transform.rotation.z);


        Vector3 cameraRotationVector = 
        new Vector3(rotationX, playerCamera.transform.localRotation.y, playerCamera.transform.localRotation.z);
        
        playerCamera.transform.localRotation = Quaternion.Euler(cameraRotationVector);


    }
}
