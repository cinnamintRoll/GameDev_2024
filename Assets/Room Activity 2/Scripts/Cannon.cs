using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform launchPoint;
    [SerializeField] private float cannonPower = 10f;
    [SerializeField] private float turnSpeed = 30f;
    [SerializeField] private float upwardForce = 5f;

    //[SerializeField] private float verticalRotation = 0f;

    private void Update()
    {
        Rotation();
        Launch();
    }

    private void Rotation()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }

    //private void VerticalRotation()
    //{
    //    float verticalInput = Input.GetAxis("Vertical");
    //    verticalRotation -= verticalInput * turnSpeed * Time.deltaTime;
    //}

    // Vector3 CalculateLaunch()

    private void Launch()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    private void LaunchBall()
    {
        GameObject ball = Instantiate(ballPrefab, launchPoint.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        Vector3 launchDirection = (launchPoint.forward + Vector3.up * upwardForce).normalized;
        // Push ball out of the cannon
        rb.AddForce(launchDirection * cannonPower, ForceMode.Impulse);
    }
}
