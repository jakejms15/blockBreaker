﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Brick : MonoBehaviour {
    public static int breakableCount = 0;

    public int maxHits;
    AudioClip crack;

    LevelManager levelManager = new LevelManager();

    int timesHit;
	// Use this for initialization
	void Start () {

        breakableCount++;
        print(breakableCount);
        crack = Resources.Load("Sound/crack", typeof(AudioClip)) as AudioClip;
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        //print(gameObject.name+": "+timesHit);

        if (timesHit >= maxHits)
        {
            //TestWin();
            AudioSource.PlayClipAtPoint(crack, this.transform.position);
            breakableCount--;
            print(breakableCount);
            Destroy(gameObject);
        }
    }

    void TestWin()
    {
        levelManager.LoadNextScene();
    }
}
