using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCamerOverlord : MonoBehaviour {

	// what to create on click
	public GameObject prefab1;
	public GameObject prefab2;
	public bool ready = false;
	public bool ready1 = false;


	// Try this out

	public GameObject lineprefab;
	public GameObject linehandler;
	public Vector3 mousepos;

	// how far, more or less, do you want it to go?
	public float distance = 10f;	

	// how fast?
	public float power = 2000f;

	// Update is called once per frame
	void Update () {
		// if one is presssed
		if (Input.GetKeyDown (KeyCode.Alpha1) && ready1 == false) {
			ready = !ready;
			Debug.Log (ready);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)&& ready == false) {
			ready1 = !ready1;
			Debug.Log (ready1	);
		}


		// on left click
		if (Input.GetMouseButtonDown(0) && ready == true) {

			// converting 2d screen coordinates to 3d "world" coordinates**********
			Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			position = Camera.main.ScreenToWorldPoint(position);

			// spawn an object and give it a push
			GameObject go = Instantiate(prefab1, transform.position, Quaternion.identity) as GameObject;
			go.transform.LookAt(position);    
			go.GetComponent<Rigidbody>().AddForce(go.transform.forward * power);
		}
		if (Input.GetMouseButtonDown(0) && ready1 == true && ready == false) {

			mousepos = Input.mousePosition;
			mousepos.z = 10;

			mousepos = Camera.main.ScreenToWorldPoint(mousepos);
			linehandler = Instantiate(prefab2, mousepos, Quaternion.identity) as GameObject;
		}

	}
}	