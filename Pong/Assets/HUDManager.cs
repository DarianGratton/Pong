using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    Text HUDText;
    public int score = 0;
    public int maxScore = 10;            
    public bool playerScored = true;    
    private Text winnerText;
    private string oriString;           // String to keep track of the original text before score is added
    
    // Use this for initialization
	void Start ()
    {
        winnerText = GameObject.Find("WinnerText").GetComponent<Text>();
        HUDText = GetComponent<Text>();
        oriString = HUDText.text.ToString();

        winnerText.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if player scored and adds score to player text that scored
        if (playerScored)
        {
            HUDText.text = oriString + ": "+ score.ToString();
            playerScored = !playerScored;
        }

        // Check if score is greater than the max score and announces winner
        if (score > maxScore)
        {
            winnerText.text = "Winner: " + oriString;
            winnerText.enabled = true;
        }
	}
}
