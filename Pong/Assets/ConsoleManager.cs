using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleManager : MonoBehaviour {

    private Canvas console;

	// Use this for initialization
	void Start ()
    {
        console = GameObject.Find("Console").GetComponent<Canvas>();

        CloseTheConsole();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.C))
        {
            console.enabled = true;
        }
	}

    public void CloseTheConsole()
    {
        console.enabled = false;
    }
}
