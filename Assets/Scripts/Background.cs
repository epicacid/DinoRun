using UnityEngine;
using System.Collections;
public class Background : MonoBehaviour {
	Vector3 background;
	private float _x;

	[SerializeField]
	private float _width = 15.0f;


	void OnBecameInvisible()
	{
		background = gameObject.transform.position;
		_x = background.x + _width * 2;
	
		gameObject.transform.position = new Vector3 (_x, 0f, 0f);
	}
}

