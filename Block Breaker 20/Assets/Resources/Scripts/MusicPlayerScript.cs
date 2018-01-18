using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript: MonoBehaviour {

    static MusicPlayerScript instance = null;

    private void Awake()
    {
        print("Player Awake");
    }

    // Use this for initialization
    void Start () {
        print("Player Start");

        if(instance != null)
        {
            print("Duplicate Music Player is self-Destructing");
            Destroy(gameObject);
        }
        else //INSTANCE IS STILL NULL
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
