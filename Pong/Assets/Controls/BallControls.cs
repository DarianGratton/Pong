using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour {

    public float thrust = 0.5f;
    private Rigidbody rb;
    private Vector3 startPosition;
    private Vector3 currentVelocity;

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

    public void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    public void StopBall()
    {
        currentVelocity = rb.velocity;
        Debug.Log(currentVelocity);
        rb.velocity = Vector3.zero;
    }

    public void ResumeBall()
    {
        Debug.Log(currentVelocity);
        rb.AddForce(currentVelocity.x, currentVelocity.y, currentVelocity.z);
    }
}
