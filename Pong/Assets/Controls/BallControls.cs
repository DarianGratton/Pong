using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 startPosition;

	// Use this for initialization
	void Start ()
    { 
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        Invoke("GoBall", 2);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector3(20, -15, 0));
        }
        else
        {
            rb.AddForce(new Vector3(-20, -15, 0));
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }
}
