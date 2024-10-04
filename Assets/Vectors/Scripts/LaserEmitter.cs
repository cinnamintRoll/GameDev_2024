using UnityEngine;

public class LaserEmitter : MonoBehaviour
{
    [SerializeField] private int maxBounces = 5;
    [SerializeField] private LineRenderer laserLine;
    [SerializeField] private GameObject winGame;
    [SerializeField] private float targetHitTime = 3f;

    private float currentHitTime = 0f;
    private bool isHittingTarget = false;

    private void Update()
    {
        // DIRECTION
        Vector2 direction = transform.up;
        CastLaser(transform.position, direction);

        // check if the target is being hit
        if (isHittingTarget)
        {
            currentHitTime += Time.deltaTime;
            if (currentHitTime >= targetHitTime)
            {
                winGame.SetActive(true);
            }
        }
        else
        {
            // Reset timer if not continuously hit
            currentHitTime = 0f;
        }

        isHittingTarget = false; // Reset after each update cycle
    }

    private void CastLaser(Vector2 position, Vector2 direction)
    {
        laserLine.positionCount = 1;
        laserLine.SetPosition(0, position);

        for (int i = 0; i < maxBounces; i++)
        {
            RaycastHit2D hit = Physics2D.Raycast(position, direction); // RAYCAST

            if (hit.collider != null)
            {
                HandleHit(hit, ref position, ref direction);
            }
            else
            {
                ExtendLaser(position, direction);
                break;
            }
        }
    }

    private void HandleHit(RaycastHit2D hit, ref Vector2 position, ref Vector2 direction)
    {
        laserLine.positionCount++; // increase pos count
        laserLine.SetPosition(laserLine.positionCount - 1, hit.point);

        if (hit.collider.CompareTag("Target"))
        {
            Debug.Log("Target is being hit!");
            isHittingTarget = true;
        }

        position = hit.point; // update position
        direction = Vector2.Reflect(direction, hit.normal).normalized; // reflect the direction
    }

    private void ExtendLaser(Vector2 position, Vector2 direction)
    {
        laserLine.positionCount++;
        laserLine.SetPosition(laserLine.positionCount - 1, position + direction * 100);
    }
}
