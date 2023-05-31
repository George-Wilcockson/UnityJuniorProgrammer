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

    public int ballCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        ballCount = 0;
        ballInPlay = false;
    }

    void Update()
    {
        // if the object does NOT exists and space bar pressed
        if(GameObject.Find("Ball1(Clone)") == null && Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
        
    }

    // Update is called once per frame
    void SpawnBall()
    {
        Debug.Log("Is ball in play? " + ballInPlay + "\n how many balls? " + ballCount);

        Instantiate(ball, spawnPos, ball.transform.rotation);
    }
}
