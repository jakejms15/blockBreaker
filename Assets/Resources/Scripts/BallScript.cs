using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    PaddleScript paddle;
    Vector3 paddleBallPosDiff;
    bool gameStart = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<PaddleScript>();

        paddleBallPosDiff = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (!gameStart) {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart) {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;

        //if (gameStart && (colName == "Paddle" || colName == "Left Border" || colName == "Right Border")) {
        if(gameStart && collision.collider.tag != "Breakable")
        { 
            GetComponent<AudioSource>().Play();

            Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0f, 0.2f));
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
