using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    // gameObject is the UI text

    public GameObject gameOver;
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // The gameObject is updated here
        gameOver.GetComponent<TextMesh>().text = $"Game Over: {scoreKeeper.score.ToString()}";
    }

    // Is triggered when two objects collide, horse + pizza/player
    private void OnTriggerEnter(Collider other)
    {
        // Score is added upon collision
        scoreKeeper.score++;

        // Both colliding objects are destroyed
        // gameOver UI is added only to the player, so it displays when player is hit
        Destroy(gameObject);
        Destroy(other.gameObject);

        // This displays the text in the gameOver UI
        gameOver.SetActive(true);
    }

    
}