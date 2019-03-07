using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	
	public void ChangetoGame(){
		SceneManager.LoadScene("Interactions_Example");
	}
	
	public void ChangetoTitle(){
		SceneManager.LoadScene("Menu_copy");
	}

	public void ChangetoControls(){
		SceneManager.LoadScene("Controls Menu");
	}
	
	public void ChangetoVive(){
		SceneManager.LoadScene("Controller Vive");
	}

	public void ChangetoRift(){
		SceneManager.LoadScene("Controls Rift");
	}

	public void ChangetoOptions(){
		SceneManager.LoadScene("Volume Scene");
	}

	public void Exit(){
		Application.Quit();
	}

}
