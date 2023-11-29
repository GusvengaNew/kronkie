using UnityEngine;

public class PaperThrow : MonoBehaviour
{
    public Vector3 throwDirection = Vector3.forward; // Default throw direction
    public float throwForce = 10f; // Default throw force

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component on the object
        rb = GetComponent<Rigidbody>();

        // Throw the object when it becomes active
        if (isActiveAndEnabled)
        {
            ThrowObject();
        }
    }

    void ThrowObject()
    {
        // Check if the Rigidbody component exists
        if (rb != null)
        {
            // Apply force to throw the object
            rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found on the object.");
        }
    }
}
