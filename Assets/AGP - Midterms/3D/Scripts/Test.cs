using UnityEngine;

public class Test : MonoBehaviour
{

    //variables for acceleration
    public float acceleration = 0.1f;
    public float velocity = 0.0f;
    public float maxSpeed = 5.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Create a basic code that will demonstrate Acceleration in Unity
    void Acceleration()
    {
        float acceleration = 0.1f;
        float velocity = 0.0f;
        float maxSpeed = 5.0f;

        velocity += acceleration * Time.deltaTime;

        if (velocity > maxSpeed)
        {
            velocity = maxSpeed;
        }
    }

    //Create a basic code that will demonstrate Velocity in Unity

}
