using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float minX = 2.3f;
    public float maxX = 2.5f;
    public float minZ = 0.3f;
    public float maxZ = 0.5f;
    public float yPosition = 2f;
    public float updateInterval = 2f;

    private void Start()
    {
        // Set the initial position
        MoveToRandomPosition();

        // Invoke MoveToRandomPosition every updateInterval seconds, starting after 2 seconds
        InvokeRepeating("MoveToRandomPosition", 2f, updateInterval);
    }

    private void MoveToRandomPosition()
    {
        // Generate random x and z positions within the specified ranges
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        // Set the object's position with the fixed y position
        transform.position = new Vector3(randomX, yPosition, randomZ);
    }
}
