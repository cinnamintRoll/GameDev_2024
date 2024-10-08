using UnityEngine;

public class Acceleration : MonoBehaviour
{
    // This script is meant to demonstrate acceleration in Unity 3D in the simplest way possible
    // Variables for acceleration
    public float acceleration = 1f;
    public float maxSpeed = 5f;
    private float currentSpeed = 0f;
    private float speed = 0f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 currentVelocity = Vector3.zero;
    private Vector3 velocityVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called at a fixed interval
    void FixedUpdate()
    {
        currentSpeed += acceleration * Time.fixedDeltaTime;

        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);

        transform.position += transform.forward * currentSpeed * Time.fixedDeltaTime;
    }
}