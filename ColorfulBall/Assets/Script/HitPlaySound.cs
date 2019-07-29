using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour {

	public AudioClip sound;
	public AudioClip sound2;
	public AudioClip sound3;

	void OnTriggerEnter (Collider other) {

		if (other.CompareTag ("Wall")) {
			AudioSource.PlayClipAtPoint (sound, transform.position);
		}

		if (other.CompareTag ("OBall")) {
			Destroy (other.gameObject);
			AudioSource.PlayClipAtPoint (sound2, transform.position);
		}

		if (other.CompareTag ("Ball")) {
			AudioSource.PlayClipAtPoint (sound3, transform.position);
		}
	}
}