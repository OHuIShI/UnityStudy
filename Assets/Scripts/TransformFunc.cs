using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunc : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space))
			//transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
			gameObject.GetComponent<Rigidbody>().AddForce(transform.up*20f);

		if(Input.GetKey(KeyCode.UpArrow)) // Z
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.DownArrow)) // -Z
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.LeftArrow)) // -X
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
			//transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		if(Input.GetKey(KeyCode.RightArrow)) // X
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
			//transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
	}
}
