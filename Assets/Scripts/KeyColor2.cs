//KeyColor2.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyColor2 : MonoBehaviour {
	public GameObject otherobject;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			otherobject.GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			otherobject.GetComponent<Renderer>().material.color = Color.magenta;
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			otherobject.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
}
