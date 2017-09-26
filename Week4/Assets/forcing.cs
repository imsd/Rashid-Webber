using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcing : MonoBehaviour {

	public float forcePower = 1000f;

	// function gets called when the mouse is hovering
	// over the object
	void OnMouseDown() {
		Vector3 forceDirection = Vector3.up * forcePower;
		GetComponent<Rigidbody> ().AddForce (forceDirection);
	}

	void onTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "floor") {
			Debug.Log ("Touch");
		}
	}
}