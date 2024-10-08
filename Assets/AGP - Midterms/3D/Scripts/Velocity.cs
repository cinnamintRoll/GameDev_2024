using UnityEngine;

public class Velocity : MonoBehaviour
{
    // Variables for Velocity
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Vector3 direction = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Method for moving the object in 3D
    public void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}