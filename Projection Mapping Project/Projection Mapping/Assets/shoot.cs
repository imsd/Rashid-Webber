using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {


	public GameObject ball;
	public float power = 2000f;
	public float xDir ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject go = Instantiate (ball, transform.position, Quaternion.identity) as GameObject;
			//	go.transform.LookAt(position);    
			go.GetComponent<Rigidbody> ().AddForce(xDir, 0, -1 * power, ForceMode.Impulse);;
		}	
	}
}
