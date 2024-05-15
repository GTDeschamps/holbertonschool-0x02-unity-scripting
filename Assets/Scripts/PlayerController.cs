using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    public int health = 5;
    private int score = 0;
    // Set the score to 0
    void Start()
    {
        // Start function can remain as is if not needed for initialization
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
    void Update()
    {
          // Check if health is zero
        if (health == 0)
        {
            // Log "Game Over!" to the console
            Debug.Log("Game Over!");

            // Reload the current scene to restart the game
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false); // Disable the object
            // OR
            // Destroy(other.gameObject); // Destroy the object
        }

         // Check if the player collides with an object tagged as "Trap"
        if (other.gameObject.CompareTag("Trap"))
        {
            // Decrement the player's health
            health--;

            // Log the new health value to the console
            Debug.Log("Health: " + health);
        }

        if(other.gameObject.CompareTag("Goal"))
        {
            //win the game
            Debug.Log("You Win!");
        }
    }
}
