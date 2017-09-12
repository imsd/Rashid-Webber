using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class It2 : MonoBehaviour {

	// Use this for initialization]
	public GameObject potato;
	public Material ds2;

	public Renderer rend;

	void Start(){
		rend = GetComponent<Renderer> ();

	}
	void OnMouseEnter(){

		rend.material.color = Color.white;
	}
	void OnMouseExit(){
		rend.material.color = Color.red;	
	}

	void OnMouseOver(){
		// transform.localScale += new Vector3 (.01f, .01f, .01f);
		for (int i = 0; i < 10; i++) {

			// creating a new vector3 based on the index number
			Vector3 myVec = new Vector3(i-5,2,0);

			// create the object
			Instantiate (potato, myVec, Quaternion.identity);
		}
	}

	void OnMouseDown(){

		rend.material = ds2;
}
}
