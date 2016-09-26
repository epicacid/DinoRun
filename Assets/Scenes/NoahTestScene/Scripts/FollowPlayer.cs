using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	[SerializeField]
	private Transform _target;
	[SerializeField]
	private float _minDistance = 3.0f;
	[SerializeField]
	private float _EnemySpeed = 2.0f;
	[SerializeField]
	private float _range;

	public void FixedUpdate()
	{
		_range = Vector2.Distance (transform.position, _target.position); //Vector2.distance tussen A en B dus Enemy en Player de range slaat de waardes van de Position van Enemy en Player.
		if (_range < _minDistance) { // Als range kleiner is als minDistance begint hij hem te volgen.
			Debug.Log (_range);
			transform.position = Vector2.MoveTowards (transform.position, _target.position, _EnemySpeed * Time.deltaTime);
		}
	}
}

