using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReponsiveScaling : MonoBehaviour {

    public double scale = 1.46;

	// Use this for initialization
	void Start ()
    {
        var width = Camera.main.orthographicSize * 2.0 * Screen.width / Screen.height;

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
