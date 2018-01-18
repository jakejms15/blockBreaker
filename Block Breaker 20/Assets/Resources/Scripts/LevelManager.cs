using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScene(string sceneName)
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(sceneName);
    }

    public void LoadNextScene()
    {
        Brick.breakableCount = 0;
        //on which scene is it on?
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //On scene manager, if u win, u go to next lvl (hence currentScene + 1) 
        SceneManager.LoadScene(currentScene + 1);
    }

    public void BrickDestroyed()
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
}
