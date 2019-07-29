using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {


	Rigidbody missile;
	//PlayerR playerR;
	public float speed = -100;

	// Use this for initialization
	void Start ()
	{

		missile = this.GetComponent<Rigidbody> ();

		//playerR = this.GetComponent<PlayerR> ();

		missile.AddForce (0f, speed, 0f);

		this.transform.Rotate (180, 0, 0);

	}


	// Update is called once per frame
	void Update ()
	{
		//int count = playerR.Count;

		/* if (count <= 10) {

			speed = -200;

		} */

		if (this.transform.position.y <= -20) {
			Destroy (this.gameObject);
		}
	}
}
