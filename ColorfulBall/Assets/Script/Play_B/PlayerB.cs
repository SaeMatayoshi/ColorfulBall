using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerB : MonoBehaviour {


	const int MinLane = -1;
	const int MaxLane = 1;
	const float LaneWidth = 2.0f;

	CharacterController controller;

	public Vector3 moveDirection = Vector3.zero;
	int targetLane;

	public float gravity = 20;
	public float speedZ = 10;
	public float speedX = 5;
	public float accelerationZ = 10;
	public int Count = 0;
	public int ReScore = 0;
	//public float acceleratedZ;
	//public Vector3 globalDirection;


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

	void OnTriggerEnter (Collider other)
	{


		if (other.gameObject.tag == "OBall") {

			ReScore += 300;
			if (Count < 20) {
				speedZ += 2;
			}
			Count++;
		}

		Debug.Log (Count);
		Debug.Log (speedZ);
	}

	public void MoveToLeft ()
	{
		if (controller.isGrounded && targetLane > MinLane)
			targetLane--;
	}

	public void MoveToRight ()
	{
		if (controller.isGrounded && targetLane < MaxLane)
			targetLane++;
	}
}
