using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeChan : MonoBehaviour {


	public float thrust;
	public Rigidbody rb;
	public float timer;


	// keep track of whether or not the object is active
	bool isActive = false;

	// the renderer for this object
	public Renderer rend;

	// Use this for initialization
	void Start () {
		// at start, get the Renderer component of this object
		rend = GetComponent<Renderer> ();
		rb = GetComponent<Rigidbody>();
		timer = 3;
	}

	void Update () {
		if (isActive) {
			// shake randomly within .1 unit
			Vector3 randomShake = Random.insideUnitSphere * .7f;
			transform.position += randomShake;
			//Launch
			timer -= Time.deltaTime;
			if(timer < 0){
				rb.AddForce(transform.up * thrust);
				timer = 3f;
				isActive = !isActive;
			}
		}
	}

	void OnMouseDown() {
		// invert the value
		isActive = !isActive;

		// set color based on change
		if (isActive) {
			rend.material.color = Color.red;
		} else {
			rend.material.color = Color.white;
		}
	}
}