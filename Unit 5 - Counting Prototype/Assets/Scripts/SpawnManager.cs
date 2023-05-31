using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Reference to the ball to create
    public GameObject ball;

    // Location to spawn balls from
    private Vector3 spawnPos = new Vector3 (-18, 22, -3);
    
    // For now, a startDelay until spacebar and ballIsLive bool
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnBall", startDelay);
    }

    // Update is called once per frame
    void SpawnBall()
    {
        Instantiate(ball, spawnPos, ball.transform.rotation);
    }
}
