using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeValue = 5.0f;
    public TextMeshProUGUI timeText;
    // Get a gameManager reference
    private GameManagerX gameManagerX;

    // Start is called before the first frame update
    void Start()
    {
        // set a game manager reference
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        
    }

    // Update is called once per frame
    void Update()
    {
        while(gameManagerX.isGameActive)
        {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            Debug.Log("I still got time" + timeValue + gameManagerX.isGameActive);
            timeText.text = string.Format("Time Remaining: " + timeText);
        }
        else
        {
            Debug.Log("Time RAN OUT");
            gameManagerX.GameOver();
        }
        }
        
    }
}

