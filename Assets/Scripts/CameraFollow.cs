using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    private Vector2 velocity;

    public float smoothY;
    public float smoothX;

    public GameObject player;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.x, smoothY);

        transform.position = new Vector3(posX, posY, transform.position.z);
            
    }
	
	
}
