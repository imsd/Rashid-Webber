using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization

	public GameObject spawnSphere ;
	public GameObject spawnSquare;
	public float startAfter = 1.0f;
	public float spawnWhen = 1.0f;	

	void Start () {
		//	spawnBox = GameObject
		InvokeRepeating("SpawnThing", startAfter , spawnWhen);
		InvokeRepeating("SpawnThing2", startAfter , spawnWhen);

	}

	// Update is called once per frame
	void SpawnThing () {
		transform.position = new Vector3 (Random.Range(-5f,5f), 3, Random.Range(-5f,5f));




		Instantiate(spawnSphere,transform.position,Quaternion.identity);
		Debug.Log (transform.position);
	}
	void SpawnThing2 () {
		transform.position = new Vector3 (Random.Range(-5f,5f), 3, Random.Range(-5f,5f));




		Instantiate(spawnSquare,transform.position,Quaternion.identity);
		Debug.Log (transform.position);
	}
}
