using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;
public class SceneChange : MonoBehaviour
{
	public static int ingredienttracker = 0;
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

	public void Ham_sandwich(){
		GameObject button = GameObject.Find("Back Button");
		GameObject button2 = GameObject.Find("Back Button (1)");
		Destroy(button);
		Destroy(button2);
		SceneManager.LoadScene("Ham_Sandwich", LoadSceneMode.Additive);
	}
	public void IngUp(){
		GameObject button0 = GameObject.Find("Button0");
		GameObject button1 = GameObject.Find("Button1");
		GameObject button2 = GameObject.Find("Button2");
		GameObject button3 = GameObject.Find("Button3");
		GameObject button4 = GameObject.Find("Button4");
		Destroy(button0);
		Destroy(button1);
		Destroy(button2);
		Destroy(button3);
		Destroy(button4);
		ingredienttracker = ingredienttracker - 1;
		if (ingredienttracker == -1){
			ingredienttracker = 4;
			SceneManager.LoadScene("Ingredients4", LoadSceneMode.Additive);
		}

		else if (ingredienttracker == 0){
			SceneManager.LoadScene("Ingredients", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 1){
			SceneManager.LoadScene("Ingredients1", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 2){
			SceneManager.LoadScene("Ingredients2", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 3){
			SceneManager.LoadScene("Ingredients3", LoadSceneMode.Additive);

		}
	}

	public void IngDown(){
		GameObject button0 = GameObject.Find("Button0");
		GameObject button1 = GameObject.Find("Button1");
		GameObject button2 = GameObject.Find("Button2");
		GameObject button3 = GameObject.Find("Button3");
		GameObject button4 = GameObject.Find("Button4");
		Destroy(button0);
		Destroy(button1);
		Destroy(button2);
		Destroy(button3);
		Destroy(button4);
		ingredienttracker = ingredienttracker + 1;
		if (ingredienttracker == 5){
			ingredienttracker = 0;
			SceneManager.LoadScene("Ingredients", LoadSceneMode.Additive);
		}

		else if (ingredienttracker == 4){
			SceneManager.LoadScene("Ingredients4", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 1){
			SceneManager.LoadScene("Ingredients1", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 2){
			SceneManager.LoadScene("Ingredients2", LoadSceneMode.Additive);

		}

		else if (ingredienttracker == 3){
			SceneManager.LoadScene("Ingredients3", LoadSceneMode.Additive);

		}

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
