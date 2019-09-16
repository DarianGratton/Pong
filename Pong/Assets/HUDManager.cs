using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    Text HUDText;
    public int score = 0;
    public bool playerScored = true;
    private string oriString;
    
    // Use this for initialization
	void Start ()
    {
        HUDText = GetComponent<Text>();
        oriString = HUDText.text.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerScored)
        {
            HUDText.text = oriString + score.ToString();
            playerScored = !playerScored;
        }
	}
}
