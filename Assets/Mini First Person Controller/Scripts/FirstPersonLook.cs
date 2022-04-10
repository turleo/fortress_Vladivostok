using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public float sensitivity = 2;
    public float smoothing = 1.5f;
    private bool _isMouse = false;
    [Range(0, 100)] public float touchSensitivity;


    Vector2 velocity;
    Vector2 frameVelocity;


    void Reset()
    {
        // Get the character from the FirstPersonMovement in parents.
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }


    void Update()
    {
        if (Input.anyKeyDown && !Input.GetKey(KeyCode.Mouse0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            _isMouse = true;
        }

        if (_isMouse)
        {
            // Get smooth velocity.
            Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
            frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
            velocity += frameVelocity;
            velocity.y = Mathf.Clamp(velocity.y, -90, 90);

            // Rotate camera up-down and controller left-right from velocity.
            transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
            character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
        }
        else
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    Vector2 mouseDelta = touch.deltaPosition;
                    Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, (Vector2.one * sensitivity) / touchSensitivity);
                    frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
                    velocity += frameVelocity;
                    velocity.y = Mathf.Clamp(velocity.y, -90, 90);

                    // Rotate camera up-down and controller left-right from velocity.
                    transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
                    character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
                }
            }
        }
    }
}
