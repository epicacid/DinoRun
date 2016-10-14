using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour

{


    public float maxHealth;
    public float minHealth;

    //public GameObject overScherm;

    public float currentHealth;
    public float waarde;
    GameObject Scherm;


    // Use this for initialization
    void Start()
    {

        Scherm = GameObject.Find("gameOver");
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {



        if(waarde == 1)
        {
            Scherm.SetActive(true);
        }
        else
        {
            Scherm.SetActive(false);
        }




        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth < minHealth)
        {


            GameObject.Find("Player").GetComponent<PlayerMovementEndless>().moveSpeed = 0;

            currentHealth = 0;

            GameObject.Find("Player").GetComponent<PlayerMovementEndless>().jumpForce = 0;

            waarde = 1;
        }

    }



    




    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
        {
            currentHealth -= 1;
            Debug.Log("geraakt");

        }

    }

    
}
