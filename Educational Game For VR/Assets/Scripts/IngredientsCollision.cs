using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsCollision : MonoBehaviour
{
	int x = 0;
	//Detect collisions between the GameObjects with Colliders attached
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log(x);
		//Check for a match with the specific tag on any GameObject that collides with your GameObject
		if (collision.gameObject.tag == "bread" && x == 0 || x == 5)
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Bread accepted");
			Debug.Log("x before: " + x);
			x++;
			Debug.Log("x after: " + x);
		}
		if (collision.gameObject.tag == "ham" && x == 1)
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Ham accepted");
			Debug.Log("x before: " + x);
			x++;
			Debug.Log("x after: " + x);
		}
		if (collision.gameObject.tag == "cheese" && x == 2)
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Cheese accepted");
			Debug.Log("x before: " + x);
			x++;
			Debug.Log("x after: " + x);
		}
		if (collision.gameObject.tag == "tomato" && x == 3)
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Tomato accepted");
			Debug.Log("x before: " + x);
			x++;
			Debug.Log("x after: " + x);
		}
		if (collision.gameObject.tag == "lettuce" && x == 4)
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Lettuce accepted");
			Debug.Log("x before: " + x);
			x++;
			Debug.Log("x after: " + x);
		}
	}

	void Start(){
		Debug.Log("hola");
	}
	void Update(){
		//void OnCollisionEnter(Collision collision);
	}
}