using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject targetTeleporter; // Reference to the other teleporter plane

    void OnTriggerEnter(Collider other)
    {
        // Check if the player collides with the teleporter
        if (other.gameObject.CompareTag("Player"))
        {
            // Teleport the player to the position of the target teleporter
            other.transform.position = targetTeleporter.transform.position;
        }
    }
}
