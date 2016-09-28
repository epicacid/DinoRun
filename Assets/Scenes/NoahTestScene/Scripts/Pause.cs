using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public bool pauseMenuEnabled = false;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			pauseMenuEnabled = !pauseMenuEnabled;
		}
		if (pauseMenuEnabled) {
			Debug.Log("is paused");
			Time.timeScale = 0.0f;	
			Debug.Log (Time.timeScale);
		} else {
			Debug.Log("is playing");
			Time.timeScale = 1.0f;
			Debug.Log (Time.timeScale);
		}
	}
}


