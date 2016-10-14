using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class liveScore : MonoBehaviour {

    public Text TextScore;
   

    void Start ()
    {

       

    }
	
	
	void Update () {

        //hartjes = GameObject.Find("Player").GetComponent<PlayerHealth>().currentHealth;


        TextScore = GetComponent<Text>();
        TextScore.text = "" + GameObject.Find("Player").GetComponent<PlayerHealth>().currentHealth;

    }
}
