using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControls : MonoBehaviour
{
	//public static float volume =  0.5F;

	public void VolUp(){
		if (AudioListener.volume == 1.0F) {
			
		} 
		else {
			AudioListener.volume = AudioListener.volume + 0.1F;
			//volume = volume + 0.1F;
		}
	}

	public void VolDown(){
		if (AudioListener.volume == 0.0F) {

		} 
		else {
			AudioListener.volume = AudioListener.volume - 0.1F;
			//volume = volume - 0.1F;
		}
	}
}
