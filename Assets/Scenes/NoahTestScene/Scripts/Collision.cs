﻿using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Obstacle") {
			//Leven eraf 
			Debug.Log ("Geraakt");
		}
	}
}
