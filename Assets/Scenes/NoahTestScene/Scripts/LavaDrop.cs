using UnityEngine;
using System.Collections;

public class LavaDrop : MonoBehaviour {

	[SerializeField]
	private Transform lava;
	[SerializeField]
	private Transform spawnPoints;
	[SerializeField]
	private float _lavaSpeed = 10.0f;
	[SerializeField]
	private float maxLava = 10.0f;





	// Use this for initialization
	void Start () {
		StartCoroutine (Spawn());
	}

	IEnumerator Spawn(){
		for(int i = 0; i < maxLava; i++){
			Instantiate  (lava, spawnPoints.transform.position,Random.rotation);
		}
		yield return new WaitForSeconds (5);
		StartCoroutine (Spawn());
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
