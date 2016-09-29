using UnityEngine;
using System.Collections;

public class AutoMovement : MonoBehaviour {
	[SerializeField]
	private Transform _obstacle;
	[SerializeField]
	private Transform _targetA;
	[SerializeField]
	private Transform _targetB;
	[SerializeField]
	private float _minDistance = 0.1f;
	[SerializeField]
	private float _EnemySpeed = 2.0f;
	[SerializeField]
	private float _rangeA;
	[SerializeField]
	private float _rangeB;

	public void FixedUpdate()
	{
		_rangeA = Vector2.Distance (transform.position, _targetA.position); //Vector2.distance tussen A en B dus Enemy en Player de range slaat de waardes van de Position van Enemy en Player.
		_rangeB = Vector2.Distance (transform.position, _targetB.position);

		if (_rangeA < _minDistance) { // Als range kleiner is als minDistance begint hij hem te volgen.
			Debug.Log (_rangeA);
			transform.position = Vector2.MoveTowards (transform.position, _targetA.position, _EnemySpeed * Time.deltaTime);
			} 

		}

	
	}












