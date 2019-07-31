using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // レーン幅の上限
    const int minLane = -1;
    const int maxLane = 1;
    // レーン移動時の幅
    const float laneWidth = 2.0f;

    CharacterController CharaCon;
    Vector3 ballMove = Vector3.zero;

    // 今ボールがいるレーン
    int targetLane;

    // ボールの重力
    float gravity = 20;

    float accelerationZ = 20;
    float speedZ = 15;
    float speedX = 20;


	// Use this for initialization
	void Start ()
    {
        CharaCon = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerGetKeyDown();

        BallMove();
	}

    // ボールの動き
    void BallMove()
    {
        ballMove.z = Mathf.Clamp(accelerationZ, 0, speedZ);

        float ratioX = (targetLane * laneWidth - transform.position.x) / laneWidth;
        ballMove.x = ratioX * speedX;

        ballMove.y -= gravity + Time.deltaTime;

        Vector3 globalDirection = transform.TransformDirection(ballMove);
        CharaCon.Move(globalDirection * Time.deltaTime);
    }

    // プレイヤーがキーを押したときの処理
    void PlayerGetKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            if (targetLane > minLane)
                targetLane--;

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            if (targetLane < maxLane)
                targetLane++;
    }


}
