using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	// what to create on click
	public GameObject prefab;
	public bool ready = false;

	// how far, more or less, do you want it to go?
	public float distance = 10f;	

	// how fast?
	public float power = 2000f;

	// Update is called once per frame
	void Update () {
		// if one is presssed
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			ready = !ready;
			Debug.Log (ready);
		}


		// on left click
		if (Input.GetMouseButtonDown(0) && ready == true) {

			// converting 2d screen coordinates to 3d "world" coordinates**********
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			position = Camera.main.ScreenToWorldPoint(position);

			// spawn an object and give it a push
			GameObject go = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject;
			go.transform.LookAt(position);    
			go.GetComponent<Rigidbody>().AddForce(go.transform.forward * power);
		}
	}
}	