using System;
using UnityEngine;

namespace Move
{
    public class CubeMover : MonoBehaviour
    {
        public Joystick joystick;
        [Range(0, 1)] public float speed;

        void FixedUpdate()
        {
            transform.Translate(joystick.Direction.x * speed, 0, joystick.Direction.y * speed);
            transform.Translate(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
        }
    }
}
