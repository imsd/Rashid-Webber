using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBall : MonoBehaviour {


	public GameObject ball;
	public float power = 2000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
		GameObject go = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;    
			go.GetComponent<Rigidbody>().AddForce(go.transform.up * power);
		}
	}
}
