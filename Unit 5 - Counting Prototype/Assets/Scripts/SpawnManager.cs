using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Reference to the ball to create
    public GameObject ball;

    // Location to spawn balls from
    private Vector3 spawnPos = new Vector3 (-18, 22, -3);

    // Public so it is accessible from the box counter
    public bool ballInPlay = false;

    private int ballCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if(!ballInPlay || ballCount == 0)
        {
            SpawnBall();
            ballInPlay = true;
        }
        
    }

    // Update is called once per frame
    void SpawnBall()
    {
        Debug.Log("Is ball in play? " + ballInPlay + "\n how many balls? " + ballCount);
        // If spacebar is pressed, call spwan ball, and !ballIsLive
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, spawnPos, ball.transform.rotation);
            Debug.Log("The ball is in play? " + ballInPlay);
            ballCount++;
        }
    }
}
