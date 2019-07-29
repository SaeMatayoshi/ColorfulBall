using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Player") {
			other.gameObject.SetActive (false);

			//Invoke ("ReturnToResult", 1.0f);
		}
	}

	/* void ReturnToResult(){
		SceneManager.LoadScene ("Score");
	} */

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
