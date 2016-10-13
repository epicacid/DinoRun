using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	private float _speed = 10.0f;
	public int healthPoints = 3;
	Rigidbody2D rb2;
	public bool movementEnabled = true;



	void Start(){
		rb2 = GetComponent<Rigidbody2D> ();
	}

	void Update (){
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("recht");
			rb2.AddForce (Vector2.right * Time.deltaTime * _speed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("link");
			rb2.AddForce (Vector2.left * Time.deltaTime * _speed);
			}
		}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "obstacle"){
			healthPoints -= 1;
			Debug.Log ("geraakt");

	}

	}
}

