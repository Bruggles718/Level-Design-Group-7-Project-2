using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 100f;
    [SerializeField] private Transform playerBody;

    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * this.mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * this.mouseSensitivity * Time.deltaTime;

        this.xRotation -= mouseY;
        this.xRotation = Mathf.Clamp(this.xRotation, -90f, 90f);

        this.transform.localRotation = Quaternion.Euler(this.xRotation, 0f, 0f);

        this.playerBody.Rotate(Vector3.up * mouseX);

    }
}
