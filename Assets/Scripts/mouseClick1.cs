using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick1 : MonoBehaviour {

	void OnMouseDown()
	{
		GetComponent<Rigidbody> ().AddForce (transform.forward * 1000f);
	}
}
