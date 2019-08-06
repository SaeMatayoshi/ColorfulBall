using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissileFall : MonoBehaviour {

	public GameObject Prefab;
	public GameObject player;
	private Vector3 Instan;

	public PlayerR playerR;
	public PlayerB playerB;
	public PlayerG playerG;

	public float span = 2f;
	//public float z;
	public float speedZ = 10;
	public float distan = 50;
    // ミサイルが落ちてきた数
	private int count = 0;


	// Use this for initialization
	void Start ()
	{
		StartCoroutine ("Fall");

        if (SceneManager.GetActiveScene().name == "PlayRed")
        {
            count = playerR.Count;
        }
        else if (SceneManager.GetActiveScene().name == "PlayBlue")
        {
            count = playerB.Count;
        }
        else if (SceneManager.GetActiveScene().name == "PlayGreen")
        {
            count = playerG.Count;
        }
    }

	IEnumerator Fall ()
	{
		while (true) {

			//Debug.Log (count);

			float x = Random.Range (-3f, 3f);
			float y = 50;
			float z = player.transform.position.z;

            // プレイヤーの速さにあわせる
			if (count <= 20) {
				speedZ = 10 * count + distan;
			}

			Instan = new Vector3 (x, y, z + speedZ);

			Instantiate (
				Prefab,
				Instan,
				Quaternion.identity
			);

			yield return new WaitForSeconds (span);

			Instan = Vector3.zero;
            // 変数の初期化
			if (count <= 20) {
				speedZ = 10;
			}

			if (player == false) {
				enabled = false;
			}

		}
	}

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Ball") {

			count++;
			distan += 100;

			speedZ += 20 * count;
		}
	}
}
