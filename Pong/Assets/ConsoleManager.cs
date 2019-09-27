using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleManager : MonoBehaviour {

    private Canvas console;
    private Camera camera;

	// Use this for initialization
	void Start ()
    {
        var input = GameObject.Find("ConsoleField").GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        input.onEndEdit.AddListener(SubmitCommand);

        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
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

    public void SubmitCommand(string command)
    {
        switch (command.ToLower())
        {
            case "red":
                camera.backgroundColor = Color.red;
                break;
            case "blue":
                camera.backgroundColor = Color.blue;
                break;
            case "cyan":
                camera.backgroundColor = Color.cyan;
                break;
            case "gray":
                camera.backgroundColor = Color.gray;
                break;
            case "green":
                camera.backgroundColor = Color.green;
                break;
            case "magenta":
                camera.backgroundColor = Color.magenta;
                break;
            case "yellow":
                camera.backgroundColor = Color.yellow;
                break;
        }
    }
}
