using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    private GameObject topBound;
    private GameObject bottomBound;
    
    // Use this for initialization
	void Start ()
    {
        topBound = GameObject.Find("TopBoundary");
        bottomBound = GameObject.Find("BottomBoundary");
    }
	
	// Update is called once per frame
	void Update ()
    {
        // When player pushesup check if below top boundary and move up paddle if true
        if (Input.GetKey(moveUp)
            && (topBound.transform.position.y - 2) > transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y + 0.1);
            this.transform.position = position;
        }

        // When player pushesup check if above bottom boundary and move down paddle if true
        if (Input.GetKey(moveDown)
             && (bottomBound.transform.position.y + 2) < transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y - 0.1);
            this.transform.position = position;
        }
    }
}
