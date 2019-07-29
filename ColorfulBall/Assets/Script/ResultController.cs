using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour {

	public Text ScoreLabel;
	public Text HighScoreLabel;
	public GameObject player;
	GameObject Player;
	GameObject gamecon;

	// Use this for initialization
	void Start ()
	{
		int resultScore = GameController.score;

		ScoreLabel.text = "スコア : " + resultScore;
		HighScoreLabel.text = "ハイスコア : " + PlayerPrefs.GetInt ("HighScore");

		Player = GameObject.Find ("Player");
		gamecon = GameObject.Find ("GameController");
	}

	public void OnStartButtonClicked ()
	{
		SceneManager.LoadScene ("Select");

		Destroy (Player);
		Destroy (gamecon);

	}

	public void OnTitleButtonClicked(){
		SceneManager.LoadScene ("Title");
	}


	// Update is called once per frame
	void Update ()
	{

	}
}