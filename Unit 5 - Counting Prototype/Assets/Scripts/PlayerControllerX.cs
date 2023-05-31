using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody leftPaddle;
    private Rigidbody rightPaddle;
    
    // Start is called before the first frame update
    void Start()
    {
        leftPaddle = GetComponent<Rigidbody>();
        rightPaddle = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            Debug.Log("'a' was pressed");
        }

        if(Input.GetKey("d"))
        {
            Debug.Log("'w' was pressed");
        }

    }
}
