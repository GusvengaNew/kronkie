using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    void Update()
    {
        // Example: Check for a specific condition (e.g., press a key) to destroy the object
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Destroy the GameObject this script is attached to
            Destroy(gameObject);
        }
    }
}
