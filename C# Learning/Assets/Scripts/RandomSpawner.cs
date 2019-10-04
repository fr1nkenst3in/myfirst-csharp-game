using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	PlayerCounter counter;
	private float randomx;
	private float randomy;
	private Vector3 newPos;
	void OnTriggerEnter(Collider col)
	{
		//Checks if the player hits the trigger and sends a randomise function
		//to randomise its location as well as increase the points by 10
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Player Entered");
			counter = col.gameObject.GetComponent<PlayerCounter> ();
			RandomisePosition();
		//
		}
	}
	void RandomisePosition(){
		//Randomises Position and Increases Points by 10
		counter.playerPoints = counter.playerPoints + 10f;
		randomx = Random.Range (-3, 3);
		randomy = Random.Range (-3, 3);
		newPos.x = randomx;
		newPos.y = 0.4f;
		newPos.z = randomy;
		transform.localPosition = newPos;
		//
	}
}
