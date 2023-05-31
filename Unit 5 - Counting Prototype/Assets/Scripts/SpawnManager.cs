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
    public bool deadBall = false;

    // Start is called before the first frame update
    void Start()
    {
        deadBall = false;
    }

    void Update()
    {
        if(deadBall)
        {
            SpawnBall();
        }
        
    }

    // Update is called once per frame
    void SpawnBall()
    {
        // If spacebar is pressed, call spwan ball, and !ballIsLive
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, spawnPos, ball.transform.rotation);
            deadBall = false;
        }
    }
}