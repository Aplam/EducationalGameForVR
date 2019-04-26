using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_height : MonoBehaviour
{
	private float currentHeight = 0.4778785f;

	[SerializeField]
	private Camera VRCamera;

	public void ResizeUp()
	{
		currentHeight = currentHeight + 0.1f;
		transform.localPosition = new Vector3(60.92627f, currentHeight, 265.2031f);
	}

	public void ResizeDown()
	{
		currentHeight = currentHeight - 0.1f;
		transform.localPosition = new Vector3(60.92627f, currentHeight, 265.2031f);
	}

}
