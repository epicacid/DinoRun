using UnityEngine;
using System.Collections;

public class HealthPickUp : MonoBehaviour {

	private Player player;



	void Awake()
	{
		player = GetComponent<Player>();
	}


	// Use this for initialization
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "HealthPickUp") {
			player.healthPoints += 1;

		}

	}

}
