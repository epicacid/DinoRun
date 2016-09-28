using UnityEngine;
using System.Collections;

public class AutoMovement : MonoBehaviour {

	Transform Obstacle;
	[SerializeField]
	private float _speed = 1;

	/*
	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Right") {
			Debug.Log ("Left");
			transform.Translate (Vector2.left * Time.deltaTime * _speed);
		} 
		if (coll.gameObject.tag == "Left") {
			Debug.Log ("Right");
			transform.Translate (Vector2.right * Time.deltaTime * _speed);
		}
	}
	*/

	
}






