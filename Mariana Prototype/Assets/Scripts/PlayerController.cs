using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;

    private float verticalRotation = 0;
    private CharacterController characterController;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Player rotation (looking)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

        transform.Rotate(Vector3.up * mouseX);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        // Player movement
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 moveDirection = Camera.main.transform.forward * verticalMovement + Camera.main.transform.right * horizontalMovement;
        moveDirection.y = 0; // Ensure no vertical movement
        moveDirection.Normalize();

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        // Lock the cursor when pressing the Escape key (optional)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleCursorLock();
        }
    }

    private void ToggleCursorLock()
    {
        Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = !Cursor.visible;
    }
}
