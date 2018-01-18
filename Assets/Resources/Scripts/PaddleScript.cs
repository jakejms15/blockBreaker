using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

    public bool auto = false;
    GameObject ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {

        if(!auto)
        {
            float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;
            //float ballPosInUnits = (gameObject.transform.);

            Vector3 newPaddlePos = new Vector3(mousePosInUnits,
                                               this.transform.position.y,
                                               this.transform.position.z);

            newPaddlePos.x = Mathf.Clamp(mousePosInUnits, -7.5f, 7.5f);

            this.transform.position = newPaddlePos;
        }
        else
        {
            Vector3 newPaddlePos = new Vector3(ball.transform.position.x, 
                                               this.transform.position.y,
                                               this.transform.position.z);

            this.transform.position = newPaddlePos;
        }

    }
}
