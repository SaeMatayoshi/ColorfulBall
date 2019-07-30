using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy_B : MonoBehaviour
{

	public GameObject player;

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Player") {
			//other.gameObject.SetActive (false);

			enabled = false;

			Invoke ("ReturnToResult", 0.5f);
		}
	}

    // リザルトシーンに遷移
	void ReturnToResult ()
	{
		SceneManager.LoadScene ("Result");
		enabled = true;
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
