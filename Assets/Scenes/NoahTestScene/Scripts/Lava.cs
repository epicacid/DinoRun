﻿using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {
	Rigidbody2D rb2;
	[SerializeField]
	private float lavaSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		rb2 = gameObject.GetComponent<Rigidbody2D> ();
		MoveDown ();
	}
	
	// Update is called once per frame
	public void MoveDown(){
		rb2.AddForce (Vector2.down * lavaSpeed * Time.deltaTime);
		Debug.Log ("Lava werkt");

	}
}
