using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {

    public int resolution = 16;
    private float scale;
    private float pixelsPerUnit = 1f;
    private Camera camera;
    void Start () {
        camera = Camera.main.GetComponent<Camera>();
        float direction = Screen.height;
        scale = direction / (float)resolution;
        pixelsPerUnit *= scale;

        camera.orthographicSize = (direction / 2) / pixelsPerUnit;
        
	
	}
	
	
}
