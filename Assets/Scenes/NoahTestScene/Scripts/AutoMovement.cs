using UnityEngine;
using System.Collections;

public class AutoMovement : MonoBehaviour {

	Transform Obstacle;
	[SerializeField]
	private float _speed = 5;
	private Vector2 _newPosition = new Vector2 (4,0);








	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = Vector2.MoveTowards (new Vector (transform.position.x), _newPosition, _speed * Time.deltaTime);
		transform.Translate (Vector2.left * Time.deltaTime * _speed);



			
			
	
	}
}

