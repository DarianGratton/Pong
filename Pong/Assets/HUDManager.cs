using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    Text HUDText;
    public int score = 0;
    public int maxScore = 1;
    public bool playerScored = true;
    private Text winnerText;
    private string oriString;
    private GameObject quitButton;
    
    // Use this for initialization
	void Start ()
    {
        winnerText = GameObject.Find("WinnerText").GetComponent<Text>();
        quitButton = GameObject.Find("QuitButton");
        HUDText = GetComponent<Text>();
        oriString = HUDText.text.ToString();

        winnerText.enabled = false;
        if (quitButton)
        {
            quitButton.SetActive(false); 
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerScored)
        {
            HUDText.text = oriString + ": "+ score.ToString();
            playerScored = !playerScored;
        }

        if (score > maxScore)
        {
            winnerText.text = "Winner: " + oriString;
            winnerText.enabled = true;
            quitButton.SetActive(true);
        }
	}
}
