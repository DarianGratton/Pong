using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControls : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
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
        transform.position = Vector3.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }
}
