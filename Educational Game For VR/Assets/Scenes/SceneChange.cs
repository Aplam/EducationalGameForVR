using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

	public void ChangetoGame(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("New");
	}

	public void Pause(){
		SceneManager.LoadScene("Menu_copy", LoadSceneMode.Additive);
	}

	public void ChangetoTitle(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Menu_copy");
	}

	public void ChangetoControls(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Controls Menu");
	}

	public void ChangetoVive(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Controller Vive");
	}

	public void ChangetoRift(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Controls Rift");
	}

	public void ChangetoOptions(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Volume Scene");
	}

	public void ChangetoProgressionTracking(){
		SceneManager.LoadScene("Progression Tracking");
	}

	public void Exit(){
		Application.Quit();
	}

}
