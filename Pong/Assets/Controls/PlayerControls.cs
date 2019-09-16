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
        if (Input.GetKey(moveUp)
            && (topBound.transform.position.y - 2) > transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y + 0.1);
            this.transform.position = position;
        }

        if (Input.GetKey(moveDown)
             && (bottomBound.transform.position.y + 2) < transform.position.y)
        {
            Vector3 position = this.transform.position;
            position.y = (float)(position.y - 0.1);
            this.transform.position = position;
        }
    }
}
