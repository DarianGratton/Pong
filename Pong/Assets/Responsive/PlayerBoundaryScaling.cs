using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaryScaling : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        var width = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;
        var scale = transform.localPosition.x > 0 ? 1.46 : -1.46;

        var x = (float)(width / scale);
        var y = transform.localPosition.y;
        var z = transform.localPosition.z;

        transform.localPosition = new Vector3(x, y, z);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
