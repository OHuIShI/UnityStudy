using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSpotLight : MonoBehaviour {
	public Light SpotLight;
	// Use this for initialization
	void Start () {
		SpotLight.GetComponent<Light> ().enabled = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.S))
			SpotLight.GetComponent<Light> ().enabled = !SpotLight.GetComponent<Light> ().enabled;
	}
}
