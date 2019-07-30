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

    // メインシーンに遷移
	public void LoadScene_Main ()
	{
		SceneManager.LoadScene ("Main");
	}

    // 赤決定シーンに遷移
	public void LoadScene_Decision_red ()
	{
		SceneManager.LoadScene ("Decision_red");
	}

    // 青決定シーンに遷移
	public void LoadScene_Decision_blue(){
		SceneManager.LoadScene ("Decision_blue");
	}

    // 緑決定シーンに遷移
	public void LoadScene_Decision_green(){
		SceneManager.LoadScene ("Decision_green");
	}

    // 赤プレイシーンに遷移
	public void LoadScene_PlayRed ()
	{
		SceneManager.LoadScene ("PlayRed");
	}

    // 青プレイシーンに遷移
	public void LoadScene_PlayBlue(){
		SceneManager.LoadScene ("PlayBlue");
	}

    // 緑プレイシーンに遷移
	public void LoadScene_PlayGreen(){
		SceneManager.LoadScene ("PlayGreen");
	}

    // リザルトシーンに遷移
	public void LoadScene_Result(){
		SceneManager.LoadScene ("Result");
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
