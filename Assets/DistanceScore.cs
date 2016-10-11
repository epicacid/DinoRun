using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour
{

    public GameObject Player;
    public GameObject obj2;
    public float Score;
    public Text TextScore;
    

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }


    void Update()
    {

         
        
        Score = obj2.transform.position.x + Player.transform.position.x / 10;
        


        

        TextScore = GetComponent<Text>();
        TextScore.text = "" +Score.ToString("F0");


    }

}
