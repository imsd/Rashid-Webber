using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageSpawner : MonoBehaviour {

	public GameObject target;
	public GameObject yay;
	public Vector3 spawnLocation;
	public bool celebrate = false;
	public float countdown;
//	public  int targetXlocation;




	// Use this for initialization
	void Start () {

	//	Vector3 spawnLocation =  new Vector3 (35f, 7.8f, -20f);
		
	}
	
	// Update is called once per frame
	void Update (){
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			Instantiate(target,new Vector3(Random.Range(-30f,100f), 7.8f, -20f),Quaternion.Euler(0,-31.9f,0));
	}
		if(Input.GetKeyDown(KeyCode.Alpha4) && celebrate == false){
			Instantiate (yay,new Vector3(0,0,0),Quaternion.Euler(270,0,0));
			Instantiate (yay,new Vector3(74,0,0),Quaternion.Euler(270,0,0));
			Instantiate (yay,new Vector3(77.93f,0,-53.7f),Quaternion.Euler(270,0,0));
			Instantiate (yay,new Vector3(49.5f,0,-59.3f),Quaternion.Euler(270,0,0));
			celebrate = !celebrate;
		}

		countdown += Time.deltaTime;
		if(countdown > 12){
			celebrate = !celebrate;
			Debug.Log ("Ready to fire captain");
		}
	}
}
