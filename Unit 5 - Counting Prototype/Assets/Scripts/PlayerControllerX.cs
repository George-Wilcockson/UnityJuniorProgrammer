using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // We don't need to access the paddles, just the springs that control them!

    // Visible private field of speed to move the paddles [SerializeField]
    // Angles of paddles
    public float restPos = 0f;
    public float pressedPos = -45f;
    public float paddleStrength = 10000f;
    public float paddleDamper = 150f;
    HingeJoint hinge;

    // The name of the axis
    public string inputName;

    
    // Start is called before the first frame update
    void Start()
    {
        // Initialise the hinges
        hinge = GetComponent<HingeJoint>();
        // Hinge uses the spring skill
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Set the springs values
        JointSpring spring = new JointSpring();
        spring.spring = paddleStrength;
        spring.damper = paddleDamper;
        // Move left paddle
        if(Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPos;

        }
        else
        {
            spring.targetPosition = restPos;
        }

        hinge.spring = spring;
        hinge.useLimits = true;

                // Move right paddle
        if(Input.GetKey("s"))
        {
            Debug.Log("'s' was pressed");
        }
        
    }
}
