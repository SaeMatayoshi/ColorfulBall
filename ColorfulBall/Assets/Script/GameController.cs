using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

	public GameObject player;
	public Text ScoreLabel;
	int highscore;
	public static int score;
	public GameObject canvas;
	int score2;
	bool PlayScene = true;

	public PlayerR playerR;
	public PlayerB playerB;
	public PlayerG playerG;

	// Use this for initialization
	void Start ()
	{		
		DontDestroyOnLoad (this);

		DontDestroyOnLoad (player);
	}

	// Update is called once per frame
	public void Update ()
	{	
		if (SceneManager.GetActiveScene ().name == "Result") {

			PlayScene = false;
		}

		if (SceneManager.GetActiveScene ().name == "Select") {

			Destroy (this.gameObject);
			Destroy (player);
		}

		if (PlayScene) {
			if (SceneManager.GetActiveScene ().name == "PlayRed") {
				score2 = playerR.ReScore;
			} else if (SceneManager.GetActiveScene ().name == "PlayBlue") {
				score2 = playerB.ReScore;
			} else if (SceneManager.GetActiveScene ().name == "PlayGreen") {
				score2 = playerG.ReScore;
			}
			score = (int)player.transform.position.z + score2;

			ScoreLabel.text = "" + score;
		}

		if (highscore < score) {
			highscore = score;
		}

		if (player.transform.position.y < 0.68f) {

			enabled = false;

			Score ();

			Invoke ("ReturnToTitle", 0.5f); 
		}
	}

	public void Score ()
	{
		if (PlayerPrefs.GetInt ("HighScore") < score) {
			PlayerPrefs.SetInt ("HighScore", score);
		} 
	}

	void load ()
	{
		DontDestroyOnLoad (ScoreLabel);

		Debug.Log ("trace!!");
	}

	void ReturnToTitle ()
	{
		SceneManager.LoadScene ("Result");
	}

	public void OnStartButtonClicked(){
		//Destroy (this.gameObject);
		//Destroy (player);

		SceneManager.LoadScene ("Select");
	}
}
