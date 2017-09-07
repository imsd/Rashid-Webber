using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

	// Use this for initialization

	public GameObject spawnBox ;
	public float startAfter = 1.0f;
	public float spawnWhen = 0.5f;	

	void Start () {
	//	spawnBox = GameObject
		InvokeRepeating("SpawnThing", startAfter , spawnWhen);
		//first argument is the ofucntion u want to repeat
		// after how many seconds do you want it start
		// how many seconds of repetition
	}
	
	// Update is called once per frame
	void SpawnThing () {
		transform.position = new Vector3 (Random.Range(-5f,5f), 3, Random.Range(-5f,5f));
		// first atgument is the object itse;f
		//second argument is the position
		// third is the rotation. 
		//Quaternion.identity = default rotation


		Instantiate(spawnBox,transform.position,Quaternion.identity);
		Debug.Log (transform.position);
	}
}
