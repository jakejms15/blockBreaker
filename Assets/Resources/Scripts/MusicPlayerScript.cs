using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;

    void Awake()
    {
        if (instance != null)
        {
            print("Duplicate Music Player is self-destructing!");
            Destroy(gameObject);
        }
        else // Instance is still null so this is the first Music Player
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
