using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField, Range(1f, 100f)]
    public float mouseSensitivity = 100f;

    [SerializeField, Range(1f, 100f)]
    public float moveSpeed = 10f;

    private float verticalInput, horizontalInput;
    private float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        HandleKeyboardInput();


        mouseX += Input.GetAxis("Mouse X") * mouseSensitivity;
        mouseY += Input.GetAxis("Mouse Y") * mouseSensitivity;

        //clamp mouseX rotation from -90 to 90 degrees
        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        transform.rotation = Quaternion.Euler(-mouseY, mouseX, 0f);
    }

    void HandleKeyboardInput()
    {
        verticalInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(horizontalInput, 0, verticalInput);
    }
}
