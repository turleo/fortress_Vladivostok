using UnityEngine;

namespace Move
{
    public class CubeMover : MonoBehaviour
    {
        public Joystick joystick;
        public GameObject[] hideOnTouch;
        [Range(0, 1)] public float speed;
        private Rigidbody _rigidbody;
        public bool isKeyboard = false;

        void Awake()
        {
            // Get the rigidbody on this.
            _rigidbody = GetComponent<Rigidbody>();
        }

    
        void FixedUpdate()
        {
            if (Input.anyKeyDown && !Input.GetKey(KeyCode.Mouse0))
            {
                foreach (var o in hideOnTouch)
                {
                    o.SetActive(false);
                }

                isKeyboard = true;
            }

            if (!isKeyboard)
            {
                transform.Translate(joystick.Direction.x * speed, 0, joystick.Direction.y * speed);
                Vector2 targetVelocity = new Vector2( Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
                _rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, _rigidbody.velocity.y, targetVelocity.y);
            }

        }
    }
}
