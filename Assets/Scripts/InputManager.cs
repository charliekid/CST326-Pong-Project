using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    GameObject rightPaddle;
    GameObject leftPaddle;
    GameObject ball;

    public float leftScore = 0;
    public float rightScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        rightPaddle = GameObject.Find("PaddleRight");
        leftPaddle = GameObject.Find("PaddleLeft");
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        // if the ball is passed 11.15 on the x position score is to the left paddle
        // if ball is pass -40 on the x position score is  the right paddle
        if (ball.transform.position.x > 12)
        {
            LeftScored();
        }
        if (ball.transform.position.x < -12)
        {
            RightScored();
        }


    }
    public void LeftScored()
    {
        Debug.Log("LEFT PERSON SCORES");
        leftScore++;
        rightPaddle.transform.position = new Vector3(10, 1, 0);
        ball.transform.position = new Vector3(9, 1, 0);
        Debug.Log("CURRENT SCORE |L:" + leftScore + " R:" + rightScore + "|");

    }

    public void RightScored()
    {
        Debug.Log("RIGHT PERSON SCORES");
        rightScore++;
        leftPaddle.transform.position = new Vector3(-10, 1, 0);
        ball.transform.position = new Vector3(-9, 1, 0);
        Debug.Log("CURRENT SCORE |L:" + leftScore + " R:" + rightScore + "|");
    }
}
