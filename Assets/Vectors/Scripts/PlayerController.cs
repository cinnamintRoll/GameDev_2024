using UnityEngine;

public class PlayerController : MonoBehaviour // DIRECTION
{
    [SerializeField] private float rotationSpeed = 100f;
    private void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward, rotationAmount);
    }
}