using UnityEngine;

public class Rotation : MonoBehaviour
{

    //Variables for rotation
    public float rotationSpeed = 100.0f;
    public float rotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    // Method to demonstrate rotating object in unity 3d in the simplest way possible
    void Rotate()
    {
        rotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, rotation, 0);
    }
}
