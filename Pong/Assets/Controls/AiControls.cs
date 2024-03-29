﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiControls : MonoBehaviour {

    private GameObject ball;
    private GameObject topBound;
    private GameObject bottomBound;

    // Use this for initialization
    void Start ()
    {
        ball = GameObject.Find("Ball");
        topBound = GameObject.Find("TopBoundary");
        bottomBound = GameObject.Find("BottomBoundary");
    }
	 
	// Update is called once per frame
	void Update ()
    {
        // Checks for y position and the top boundary so the Ai doesn't fly through it 
        if (transform.position.y < ball.transform.position.y
            && (topBound.transform.position.y - 2) > transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y + 0.05);
            this.transform.position = position;
        }

        // Checks for y position and the bottom boundary so the Ai doesn't fly through it 
        if (transform.position.y > ball.transform.position.y
            && (bottomBound.transform.position.y + 2) < transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y - 0.05);
            this.transform.position = position;
        }
    }
}
