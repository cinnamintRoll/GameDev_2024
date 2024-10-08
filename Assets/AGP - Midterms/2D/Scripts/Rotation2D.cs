using UnityEngine;

public class Rotation2D : MonoBehaviour
{
    //Rotation 2D variables serializefield
    [SerializeField] private float rotationSpeed = 100.0f;
    [SerializeField] private float rotationAngle = 0.0f;
    [SerializeField] private float rotationDirection = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rotate2D();
    }

    //method for rotating the object in 2D
    public void Rotate2D()
    {
        rotationAngle = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward, rotationAngle * rotationDirection);
    }
}
