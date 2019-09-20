using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour {

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
        hudManager.score++;
        hudManager.playerScored = true;

        if (hudManager.score > hudManager.maxScore)
            ballControls.ResetBall();
        else
            ballControls.RestartGame();
    }
}
