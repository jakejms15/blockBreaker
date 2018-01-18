using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorderScript : MonoBehaviour {

    LevelManager levelManager;
    GameObject ball, paddle;
    Vector3 initialBallPos;
    Vector3 initialPaddlePos;

    public Text lives;
    int totLives = 3;

	// Use this for initialization
	void Start () {

        levelManager = GameObject.FindObjectOfType<LevelManager>();
        lives.text = "Lives: " + totLives;

        ball = Resources.Load("Prefabs/Ball") as GameObject;
        initialBallPos = ball.transform.position;

        paddle = GameObject.Find("Paddle");
        initialPaddlePos = paddle.transform.position;
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered");
        totLives--;

        if (totLives != 0)
        {
            lives.text = "Lives: " + totLives;

            Destroy(collision.gameObject);

            Instantiate(ball, initialBallPos, Quaternion.identity);
            paddle.transform.position = initialPaddlePos;
        }
        else {
            levelManager.LoadGame("Lose");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
