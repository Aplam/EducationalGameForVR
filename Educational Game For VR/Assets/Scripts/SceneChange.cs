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
		SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
		SceneManager.LoadScene("Ingredients", LoadSceneMode.Additive);
	}

	public void Recipes(){
		GameObject button = GameObject.Find("Back Button");
		GameObject button2 = GameObject.Find("Back Button (1)");
		Destroy(button);
		Destroy(button2);
		SceneManager.LoadScene("Recipes", LoadSceneMode.Additive);
	}

	public void backtopause(){
		GameObject button = GameObject.Find("Back Button");
		GameObject button2 = GameObject.Find("Back Button (1)");
		Destroy(button);
		Destroy(button2);
		SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
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
