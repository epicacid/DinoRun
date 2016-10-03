using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	[SerializeField]
	private float _minimumDist = -1.0f;
	[SerializeField]
	private float _maximumDist =  1.0f;
	[SerializeField]
	private float obstacleSpeed = 3.0f;
	[SerializeField]
	private float t = 0.0f;




	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Mathf.Lerp (_minimumDist, _maximumDist, t ),0, 0);
		t += 0.5f;


		if (t > 0.5f) {
			float temp = _maximumDist;
			_maximumDist = _minimumDist;
			_minimumDist = temp;
			t = 0.0f;

		}

	}
}
