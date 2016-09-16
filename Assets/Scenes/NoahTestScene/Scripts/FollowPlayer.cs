using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform target;
	private float minDistance = 3.0f;
	private float EnemySpeed = 2.0f;
	public float range;

	public void FixedUpdate()
	{
		range = Vector2.Distance (transform.position, target.position); //Vector2.distance tussen A en B dus Enemy en Player de range slaat de waardes van de Position van Enemy en Player.
		if (range < minDistance) { // Als range kleiner is als minDistance begint hij hem te volgen.
			Debug.Log (range);
			transform.position = Vector2.MoveTowards (transform.position, target.position, EnemySpeed * Time.deltaTime);
		}
	}
}

