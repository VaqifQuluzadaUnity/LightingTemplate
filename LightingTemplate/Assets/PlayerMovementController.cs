using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementVector = (transform.forward * verticalInput + transform.right * horizontalInput)
            * Time.deltaTime * playerSpeed;

        //transform.position += movementVector;

        transform.Translate(movementVector);
    }
}
