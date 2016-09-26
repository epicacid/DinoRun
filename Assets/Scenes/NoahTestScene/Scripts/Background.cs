using UnityEngine;
using System.Collections;
public class Background : MonoBehaviour {
	Vector3 background;
	[SerializeField]
	private float _x;
	[SerializeField]
	private float _y;
	[SerializeField]
	private float _width = 15.0f;
	[SerializeField]
	private float _height = 15.0f;
	void OnBecameInvisible()
	{
		background = gameObject.transform.position;
		_x = background.x + _width * 2;
		_y = background.y + _height * 2;
		gameObject.transform.position = new Vector3 (_x, _y, 0f);
	}
}

