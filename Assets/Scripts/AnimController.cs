using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

    private Animator anim;

  
    void Start ()
    {
        anim = GetComponent<Animator>();

        
    }
	
	
	void Update ()
    {
	    if (!GameObject.Find("Player").GetComponent<PlayerMovementEndless>().grounded)  //kijkt of grounded op de player false is
        {
            anim.SetTrigger("jump");
            anim.SetBool("Walk", false);
        }



       

        
        if (GameObject.Find("Player").GetComponent<PlayerMovementEndless>().grounded)  //kijkt of grounded op de player false is
        {
           
            anim.SetBool("Walk", true);
        }





    }
}
