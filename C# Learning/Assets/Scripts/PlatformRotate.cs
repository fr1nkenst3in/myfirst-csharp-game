using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour {


	void Update () {
		transform.Rotate (90*Time.deltaTime, 90*Time.deltaTime, 90*Time.deltaTime, Space.World);
	}
}
