using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageSpawner : MonoBehaviour {

	public GameObject target;
	public Vector3 spawnLocation;
//	public  int targetXlocation;




	// Use this for initialization
	void Start () {

	//	Vector3 spawnLocation =  new Vector3 (35f, 7.8f, -20f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha3))
			Instantiate(target,new Vector3(35f, 7.8f, -20f),Quaternion.Euler(0,-31.9f,0));
	}
}
