using UnityEngine;
using System.Collections;

public class Lava : MonoBehaviour {
	Rigidbody2D rb2;
	[SerializeField]
	private float lavaSpeed = 10.0f;
	[SerializeField]
	private float destroyTime = 0.2f;

    private Animator anim;


   









    // Use this for initialization
    void Start () {
		rb2 = gameObject.GetComponent<Rigidbody2D> ();
		MoveDown ();
        

        anim = GetComponent<Animator>();

        //StartCoroutine(Destroy());
    }
    // Update is called once per frame
    public void MoveDown(){
		rb2.AddForce (Vector2.down * lavaSpeed * Time.deltaTime);
		Debug.Log ("Lava werkt");
	}
    /*IEnumerator Destroy(){
		yield return new WaitForSeconds(destroyTime);
        
		Destroy (gameObject);
	*/


public void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ground"  )
        {
            anim.SetBool("Explosion", true);

            Destroy(gameObject, 1);
            Debug.Log("explosion");
            //Destroy(GameObject.Find("Meteor").GetComponent<PolygonCollider2D>());

        }
        if (coll.gameObject.tag == "Player")
        {

            anim.SetBool("Explosion", true);
            Destroy(gameObject,1);  

            
           // Destroy(GameObject.Find("Meteor").GetComponent<PolygonCollider2D>());
           

        }
    }


}




