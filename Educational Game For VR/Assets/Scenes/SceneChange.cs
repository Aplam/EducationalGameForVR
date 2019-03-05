using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	
	public void ChangetoGame(){
		SceneManager.LoadScene("SteamVR Test");
	}

	public void ChangetoOptions(){
		SceneManager.LoadScene("Interactions_Example");
	}

	public void Exit(){
		Application.Quit();
	}

}
