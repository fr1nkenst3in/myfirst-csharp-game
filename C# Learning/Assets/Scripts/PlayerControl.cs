using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {

	public float carSpeed = 5f;
	public float rotSpeed = 5f;
	float xspeed;
	float yspeed;
	Rigidbody rb;
	public float minSpeed;
	void Update () {
		rb = GetComponent<Rigidbody> ();
		yspeed = minSpeed + Input.GetAxis ("Vertical");
		//Offset Speed for Funky Gameplay
		xspeed = Input.GetAxis ("Horizontal");
		rb.AddRelativeForce(0, 0, yspeed * carSpeed * Time.deltaTime,ForceMode.Acceleration);
		//Car Acceleration
		transform.Rotate (0, xspeed * rotSpeed * Time.deltaTime, 0);
		//Rotates the Car
		if (transform.position.y < -3){
			Death ();
		//Checks if the car falls below a value in Y Axis and loads the menu level
		}
		}
	void Death(){
		//Loads Menu
		SceneManager.LoadScene (0);
	}
}
