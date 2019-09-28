using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPlayerLevel : MonoBehaviour {

    // Load Player vs Player game.
    public void LoadTheLevel(string theLevel)
    {
        PlayerPrefs.SetInt("Ai", 0);
        SceneManager.LoadScene(theLevel);
    }
}
