using UnityEngine;
using System.Collections;
public class Background : MonoBehaviour {
	Vector3 background;
	public float X;
	public float Y;
	public float width = 15.0f;
	public float height = 15.0f;
	void OnBecameInvisible()
	{
		background = gameObject.transform.position;
		X = background.x + width * 2;
		Y = background.y + height * 2;
		gameObject.transform.position = new Vector3 (X, Y, 0f);
	}
}

