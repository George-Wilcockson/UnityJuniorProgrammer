using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;
    
    private static List<string> textToDisplay = new List<string>();
    
    private float rotatingSpeed;
    private float timeToNextText;

    private int currentText;
    
    // Start is called before the first frame update
    void Start()
    {
        timeToNextText = 0.0f;
        currentText = 0;
        
        rotatingSpeed = 1.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        Text.text = textToDisplay[0];
        
        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Text.transform.Rotate(new Vector3(rotatingSpeed, 0, 0));

        timeToNextText += Time.deltaTime;

        if (timeToNextText > 1.5f)
        {
            timeToNextText = 0.0f;
            
            currentText++;
            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;
            }

            Text.text = textToDisplay[currentText];
        }
    }
}