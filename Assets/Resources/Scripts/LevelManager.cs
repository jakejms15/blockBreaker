using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void LoadGame(string sceneName)
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(sceneName);
    }

    public static void LoadNextScene()
    {
        // Store index of current scene in variable currentScene
        Brick.breakableCount = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

    public static void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextScene();
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
