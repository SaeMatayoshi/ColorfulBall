using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerR : MonoBehaviour {
    // レーンの最大、最小
	const int MinLane = -1;
	const int MaxLane = 1;
    // レーンからレーンまで移動する幅
	const float LaneWidth = 2.0f;

	CharacterController controller;

	public Vector3 moveDirection = Vector3.zero;
    // 今いるレーン
	int targetLane;

	public float gravity = 20;
	public float speedZ = 10;
	public float speedX = 5;
	public float accelerationZ = 10;
	public int Count = 0;
	public int ReScore = 0;

	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	public void Update ()
	{
		if (Input.GetKeyDown ("left"))
			MoveToLeft ();

		if (Input.GetKeyDown ("right"))
			MoveToRight ();

		float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
		moveDirection.z = Mathf.Clamp (acceleratedZ, 0, speedZ);

		float ratioX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;
		moveDirection.x = ratioX * speedX;

		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	}

	public void OnTriggerEnter (Collider other)
	{
        // 同じ色のボールに当たったら
		if (other.gameObject.tag == "OBall") {

			ReScore += 300;

            // スピードが上がりすぎないようにする処理
			if (Count < 40) {
				speedZ +=3;
			}
			Count++;
		}
	}

    // 左を押した時
	public void MoveToLeft ()
	{
		if (controller.isGrounded && targetLane > MinLane)
			targetLane--;
	}

    // 右を押した時
	public void MoveToRight ()
	{
		if (controller.isGrounded && targetLane < MaxLane)
			targetLane++;
	}
}
