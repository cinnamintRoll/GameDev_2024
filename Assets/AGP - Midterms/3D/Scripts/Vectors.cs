using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Transform target;  // Target object to demonstrate vector direction
    public float speed = 5f;  // Speed of movement

    void Update()
    {
        // Calculate the direction vector from the current position to the target
        Vector3 direction = target.position - transform.position;

        // Normalize the direction vector (makes it length 1)
        Vector3 normalizedDirection = direction.normalized;

        // Get the magnitude of the direction vector (distance between the objects)
        float distance = direction.magnitude;

        // Print information about the vector
        Debug.Log("Direction: " + direction);
        Debug.Log("Normalized Direction: " + normalizedDirection);
        Debug.Log("Distance (Magnitude): " + distance);

        // Move the object towards the target using normalized direction
        if (distance > 0.1f)
        {
            transform.position += normalizedDirection * speed * Time.deltaTime;
        }
    }
}