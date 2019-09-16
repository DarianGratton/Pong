using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y + 0.1);
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y - 0.1);
            this.transform.position = position;
        }
    }
}
