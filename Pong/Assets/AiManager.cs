using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("Ai") == 1)
        {
            this.GetComponent<PlayerControls>().enabled = false;
        }
        else
        {
            this.GetComponent<AiControls>().enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
