using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {


	public GameObject canvas;

	// Use this for initialization
	void Start () {

	}

	public void load(){
		canvas.transform.parent = null;

		DontDestroyOnLoad (canvas.gameObject);
	}
	// Update is called once per frame
	void Update () {

	}
}