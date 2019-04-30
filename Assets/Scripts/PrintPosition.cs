//PrintPosition.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPosition : MonoBehaviour {

	public GameObject otherobject;
	Vector3 pos;

	// Update is called once per frame
	void Update () {
		pos = otherobject.GetComponent<Transform> ().position;
		Debug.Log ("Ball position = " + pos);
	}
}
