using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDirectionalLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Light> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.D))
			gameObject.GetComponent<Light> ().enabled = !GetComponent<Light> ().enabled;
	}
}
