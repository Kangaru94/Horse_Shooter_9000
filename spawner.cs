using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    // gameObject spawns horses, float is the interval at which they're spawned
    public GameObject[] animalSpawner;
    private float spawnTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //This spawns the horses at steady intervals, referencing the variables above
        InvokeRepeating("SpawnAHorse", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnAHorse()
    {
        // animalIndex is a range the length of the gameObject array
        // The Vector3 is the range of positions on the x/z axis that a horse can be spawned
        int animalIndex = Random.Range(0, animalSpawner.Length);
        Vector3 spawnerPosition = new Vector3(Random.Range(-6, 17), 0, 25);

        // This creates new instances of horses at random
        Instantiate(animalSpawner[animalIndex], spawnerPosition, animalSpawner[animalIndex].transform.rotation);
    }
}
