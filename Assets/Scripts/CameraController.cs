using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -5);

    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
