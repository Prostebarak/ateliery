using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public float sensitivity = 2;
    public float smoothing = 1.5f;

    Vector2 velocity;
    Vector2 frameVelocity;


    void Reset()
    {
        // Get the character from the FirstPersonMovement in parents.
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }

    void Start()
    {
        // Lock the mouse cursor to the game screen.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Toggle cursor lock/unlock when pressing a specific key (e.g., "Escape")
        if (Input.GetKey(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None; // Unlock the cursor
                Cursor.visible = true;                 // Make the cursor visible
            }
            
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked; // Lock the cursor again
            Cursor.visible = false;                   // Hide the cursor
        }

        // Your existing camera control code
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            // Update camera rotation only when the cursor is locked
            Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            Vector2 rawFrameVelocity = Vector2.Scale(mouseDelta, Vector2.one * sensitivity);
            frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
            velocity += frameVelocity;
            velocity.y = Mathf.Clamp(velocity.y, -90, 90);

            transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
            character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
        }
    }
}
