using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCounter : MonoBehaviour {

	public float playerPoints = 0f;
	private GameObject goText;
	private Text pointsText;
	void Update () {
		//Gets the text from UI and sets it to the current points value
		goText = GameObject.Find("Points_text");
		pointsText = goText.GetComponent<Text>();
		pointsText.text = playerPoints.ToString();
		//
	}
}
