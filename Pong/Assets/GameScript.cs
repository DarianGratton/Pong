using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public GameObject HUD;
    private HUDManager hudManager;

	// Use this for initialization
	void Start ()
    {
        hudManager = HUD.GetComponent<HUDManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        hudManager.score++;
        hudManager.playerScored = true;
	}
}
