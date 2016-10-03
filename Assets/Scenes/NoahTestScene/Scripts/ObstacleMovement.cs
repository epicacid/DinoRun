using UnityEngine;
using System.Collections;

public class ObstacleMovement : MonoBehaviour {

	[SerializeField]
	private float _minimumDist;
	[SerializeField]
	private float _maximumDist;
	[SerializeField]
	private float obstacleSpeed = 3.0f;
	[SerializeField]
	private float t = 0.0f;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Mathf.Lerp (_minimumDist, _maximumDist, t ),0, 0);
		t += Time.deltaTime * obstacleSpeed;
		if (t > 1f) {
			float temp = _maximumDist;
			_maximumDist = _minimumDist;
			_minimumDist = temp;
			t = 0.0f;
		}
	}
}
