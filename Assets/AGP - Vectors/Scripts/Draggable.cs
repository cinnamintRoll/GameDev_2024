using UnityEngine;

public class Draggable : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    private float zCoord;
    private bool isDragging;

    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false; // reset
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = zCoord;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos); // conv to world space
    }
}
