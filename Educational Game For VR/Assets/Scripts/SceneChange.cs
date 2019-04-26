using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;
public class SceneChange : MonoBehaviour
{

	public void ChangetoGame(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Tableware_For_Your_Kitchen_demo");
	}

	public void Pause(){
		SceneManager.LoadScene("Menu_copy", LoadSceneMode.Additive);
	}

	public void ChangetoTitle(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Menu");
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
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Progression Tracking");
	}

	public void ChangetoFlashcards(){
		GameObject player = GameObject.Find("Player_height");
		Destroy(player);
		SceneManager.LoadScene("Flashcard Level");
	}

	public void Exit(){
		Application.Quit();
	}

}
