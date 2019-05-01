using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour {
	public GameObject myObject;
	void Start(){
		myObject.SetActive (true);
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.H)) {
			myObject.SetActive (!myObject.activeSelf);
			Debug.Log("Active Self: " + myObject.activeSelf);
		}
	}
}