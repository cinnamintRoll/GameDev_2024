using UnityEngine;

public class CubeAcceleration : MonoBehaviour
{
    [SerializeField] private float targetVelocity = 5f;
    [SerializeField] private float acceleration = 2f;
    [SerializeField] private float deceleration = 1f;

    private float velocity = 0f;
    private bool isAccelerating = true;
    //private float timePassed = 0f;

    private void Update()
    {
        //timePassed += Time.deltaTime;
        UpdateSpeed();
        MoveObject();
    }

    private void UpdateSpeed()
    {
        if (isAccelerating)
        {
            velocity += acceleration * Time.deltaTime;
            if (velocity >= targetVelocity) // stop speeding up.
            {
                velocity = targetVelocity;
                isAccelerating = false;
            }
        }
        else
        {
            velocity -= deceleration * Time.deltaTime; // Slow down
            if (velocity <= 0)  // If it stops moving
            {
                velocity = 0;
                isAccelerating = true;
            }
        }
    }

    private void MoveObject()
    {
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);
    }
}
