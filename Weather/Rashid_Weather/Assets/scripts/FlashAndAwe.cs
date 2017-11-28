using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashAndAwe : MonoBehaviour {


	public GameObject thunda;
	public float spawnTimer;
	public int destroyTimer;
	public bool alive = false;
	int spawnNow;
	public float time;
	public GameObject dio;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update(){
		
		float randomTime = Random.Range (2, 5);
	//	float randomDestro = Random.Range (1, 2);
		time += Time.deltaTime;

		if (alive == false && time > randomTime) {
			dio = Instantiate (thunda, transform.position, Quaternion.identity);
			alive = true;
		}

		if (alive == true ) {
		//	float randomDestro = Random.Range (1, 2));
			Destroy (dio, Random.Range (2, 5));
			alive = false;
			time = 0;
		}
	}
}
