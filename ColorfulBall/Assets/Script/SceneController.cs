using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

	}

	public void OnStartButtonClick ()
	{
		SceneManager.LoadScene ("Main");
	}

	public void OnRedButtonClick ()
	{
		SceneManager.LoadScene ("Decision_red");
	}

	public void OnBlueButtonClick(){
		SceneManager.LoadScene ("Decision_blue");
	}

	public void OnGreenButtonClick(){
		SceneManager.LoadScene ("Decision_green");
	}

	public void OnStartRedClick ()
	{
		SceneManager.LoadScene ("PlayRed");
	}

	public void OnStartBlueClick(){
		SceneManager.LoadScene ("PlayBlue");
	}

	public void OnStartGreenClick(){
		SceneManager.LoadScene ("PlayGreen");
	}

	public void OnBackButtonClick(){
		SceneManager.LoadScene ("Result");
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
