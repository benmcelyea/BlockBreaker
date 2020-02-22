using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Configuration Parameters
    [SerializeField] Paddle  paddle1;
    bool hasStarted = false;

    //State
    Vector2 paddleToBallVector;
    [SerializeField] float launchXAmount = 2f;
    [SerializeField] float launchYAmount = 200f;

    // Start is called before the first frame update
    void Start()
    {
        //Get the x, y difference between the paddle and ball.
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();

        }

        
    }

    private void LaunchOnMouseClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(launchXAmount, launchYAmount);


        }

    }

    private void LockBallToPaddle()
    {
        
        //Get the current Paddle position
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        //Move the ball
        transform.position = paddlePos + paddleToBallVector;
    }
}
