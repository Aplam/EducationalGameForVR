using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR;
public class SceneChange : MonoBehaviour
{
	public void recenter(){
		UnityEngine.XR.InputTracking.Recenter();

	}
	public void ChangetoGame(){
		SceneManager.LoadScene("Tableware_For_Your_Kitchen_demo");
	}
		
	public void Pause(){
		SceneManager.LoadScene("Menu_copy", LoadSceneMode.Additive);
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
