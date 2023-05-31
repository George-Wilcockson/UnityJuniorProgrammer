using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    // Refernece to the spawnmanager to access the bool
    public SpawnManager spawnManager;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Balls Used : " + Count;
        spawnManager.deadBall = true;
    }
}
