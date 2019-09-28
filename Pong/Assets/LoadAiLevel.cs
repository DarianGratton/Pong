using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAiLevel : MonoBehaviour {

    // Load Player vs Ai game.
    public void LoadTheLevel(string theLevel)
    {
        PlayerPrefs.SetInt("Ai", 1);
        SceneManager.LoadScene(theLevel);
    }

}
