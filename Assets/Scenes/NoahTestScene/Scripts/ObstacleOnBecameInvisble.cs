using UnityEngine;
using System.Collections;

public class ObstacleOnBecameInvisble : MonoBehaviour {

	[SerializeField]
	private float _width = 15.0f;
	Vector3 obstacle;
	private float _x;
	void OnBecameInvisible()
	{
		obstacle = gameObject.transform.position;
		_x = obstacle.x + _width * 2;

		gameObject.transform.position = new Vector3 (_x, 0f, 0f);
	}
}

