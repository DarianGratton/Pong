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

    // Adds force to ball
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

    // Resets ball's position to the start of the stage
    public void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }

    // Restarts game by reseting ball's position and then adding force to the ball
    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector3 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            vel.z = rb.velocity.z;
            rb.velocity = vel;
        }
    }
}
