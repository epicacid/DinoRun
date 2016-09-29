using UnityEngine;
using System.Collections;

public class PlayerMovementEndless : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D playerRigidBody;

        public bool grounded;
    public LayerMask isGround;

    private Collider2D myCollider;
	
	void Start (){
        playerRigidBody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

	}
	
	
	void Update ()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, isGround);

        playerRigidBody.velocity = new Vector2(moveSpeed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(grounded)
            {
                 playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce);
            }

           
        }


	}
}
