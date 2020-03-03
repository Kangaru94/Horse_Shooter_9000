using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPizza : MonoBehaviour
{
    // The speed at which the pizza will fly
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This moves the pizza forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
