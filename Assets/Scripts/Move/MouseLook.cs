using System;
using UnityEngine;

namespace Move
{
    public class MouseLook : MonoBehaviour
    {

        [Range(0, 500)] public float mouseSensitivity = 100f;

        public Transform playerBody;

        public Joystick joystick;

        float _xRotation = 0f;

        // Start is called before the first frame update
        void Start()
        {
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
            Cursor.lockState = CursorLockMode.Locked;
#endif
        }

        // Update is called once per frame
        void Update()
        {
            if (joystick.Direction == Vector2.zero)
            {
                float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

                _xRotation -= mouseY;
                _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

                transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
                playerBody.Rotate(Vector3.up * mouseX);
            }
        }
    }
}
    