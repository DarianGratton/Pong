using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : MonoBehaviour {

    private Canvas console;
    private Camera camera;
    private GameObject ball;
    private BallControls ballControls;

    // Use this for initialization
    void Start ()
    {
        var input = GameObject.Find("ConsoleField").GetComponent<InputField>();
        input.onEndEdit.AddListener(SubmitCommand);

        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        ball = GameObject.Find("Ball");
        console = GameObject.Find("Console").GetComponent<Canvas>();
        ballControls = ball.GetComponent<BallControls>();

        console.enabled = false;
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

    public void SubmitCommand(string command)
    {
        // Change color of background
        switch (command.ToLower())
        {
            case "background=red":
                camera.backgroundColor = Color.red;
                break;
            case "background=blue":
                camera.backgroundColor = Color.blue;
                break;
            case "background=cyan":
                camera.backgroundColor = Color.cyan;
                break;
            case "background=gray":
                camera.backgroundColor = Color.gray;
                break;
            case "background=green":
                camera.backgroundColor = Color.green;
                break;
            case "background=magenta":
                camera.backgroundColor = Color.magenta;
                break;
            case "background=yellow":
                camera.backgroundColor = Color.yellow;
                break;
        }

        // Change ball size
        switch (command.ToLower())
        {
            case "ball=big":
                ball.transform.localScale = new Vector3(2, 2, 2);
                break;
            case "ball=small":
                ball.transform.localScale = new Vector3((float) 0.25, (float) 0.25, (float) 0.25);
                break;
        }
    }
}
