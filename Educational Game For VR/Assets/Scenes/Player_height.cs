using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_height : MonoBehaviour
{
	private float currentHeight = 1.0f;

	[SerializeField]
	private Camera VRCamera;

	public void ResizeUp()
	{
		currentHeight = currentHeight + 0.1f;
		transform.localScale = new Vector3(1, currentHeight, 1);
	}

	public void ResizeDown()
	{
		currentHeight = currentHeight - 0.1f;
		transform.localScale = new Vector3(1, currentHeight, 1);
	}

}
