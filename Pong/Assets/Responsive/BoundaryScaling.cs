using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScaling : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // Gets width of camera view and changes the top and bottom boundarys based on size of camera
        var width = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;
        var scale = 1.4;

        var x = (float)(width * scale);
        var y = transform.localScale.y;
        var z = transform.localScale.z;

        transform.localScale = new Vector3(x, y, z);       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
