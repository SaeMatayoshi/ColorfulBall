﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoint : MonoBehaviour {

	public GameObject prefab;

	// Use this for initialization
	void Start ()
	{

		GameObject go = (GameObject)Instantiate (
			prefab,
			Vector3.zero,
			Quaternion.identity
		);

		go.transform.SetParent (transform, false);
	}

	void OnDrawGizmos ()
	{

		Vector3 offset = new Vector3 (0, 0.5f, 0);

		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawSphere (transform.position + offset, 0.5f);

		if (prefab != null)
			Gizmos.DrawIcon (transform.position + offset, prefab.name, true);
	}

	// Update is called once per frame
	void Update ()
	{

	}
}