using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // The horizontal input from the user
    private float horizontalInput;

    // Speed at which the player moves
    private float speed = 20f;

    // Left and right bounds of the game, keeps player on screen
    private float leftBound = -6f;
    private float rightBound = 17f;

    // The pizza in the game referenced as a gameObject
    public GameObject bulletPizza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Gets horizontal input (a/d || <-/->) from user
        horizontalInput = Input.GetAxis("Horizontal");

        // Keeps player in bounds
        if (transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }

        // Shoots pizza with space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPizza, transform.position, bulletPizza.transform.rotation);
        }

        // Moves the player left/right with corresponding horizontal input from user
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
