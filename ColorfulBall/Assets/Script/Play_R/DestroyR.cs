using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyR : MonoBehaviour {



	//public GameObject player;
	//public GameController controller;

	//public GameController controller;

	public void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Player") {
			//other.gameObject.SetActive (false);


			//enabled = false;

			Invoke ("ReturnToResult", 0.5f);
		}
	}

	void ReturnToResult ()
	{
		SceneManager.LoadScene ("Result");
		//enabled = true;

		//player.gameObject.SetActive (true);
	} 

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
