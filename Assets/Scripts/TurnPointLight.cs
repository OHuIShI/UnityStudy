using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPointLight : MonoBehaviour {
	private Light PointLight;
	// Use this for initialization
	void Start () {
		PointLight = GetComponent<Light>();
		PointLight.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.P))
			PointLight.enabled = !PointLight.enabled;
	}
}
