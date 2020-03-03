using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // These variables are the upper and lower bounds of the game screen
    private float topBound = 30;
    private float bottomBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys an object if it's too high or low on the screen
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }

    }

}
