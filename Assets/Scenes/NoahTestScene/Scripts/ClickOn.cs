using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class ClickOn : MonoBehaviour {
	
	public void OnClick(int scene){
		SceneManager.LoadScene(scene);

}

}
