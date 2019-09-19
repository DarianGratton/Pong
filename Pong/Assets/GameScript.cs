using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject HUD;
    public GameObject Ball;
    private HUDManager hudManager;
    private BallControls ballControls;

	// Use this for initialization
	void Start ()
    {
        hudManager = HUD.GetComponent<HUDManager>();
        ballControls = Ball.GetComponent<BallControls>();
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(this.ToString());
        Debug.Log(ballControls);

        hudManager.score++;
        hudManager.playerScored = true;

        ballControls.RestartGame();
    }
}
