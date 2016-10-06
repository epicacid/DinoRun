using UnityEngine;
using System.Collections;

public class RandomSpawnCoin : MonoBehaviour {
	public Transform player; 
	public Transform coin;
	public float minX;
	public float maxX;
	public float minY = 1.0f;
	public float maxY = 2.0f;
	public float minZ = 0.0f;
	public float maxZ = 0.0f;
	public int maxCoins = 5;



	void Start(){
		StartCoroutine (Spawn()); // Begin IEnumerator Spawn 

	}


	IEnumerator Spawn(){
		for (int i = 0; i < maxCoins; i++) { //The int named i = 0 if i is lower the value in maxCoins its getting a coin
			Vector3 x = new Vector3 (Random.Range(player.position.x+5f, player.position.x+7.5f), Random.Range(player.position.y+1.0f,player.position.y+2.0f)); /*
			Making a new vector 3 and naming it x saying it can place its coins between 2 x axis. In this case its the player.position.x + 5f as the minimum and 
			player.position.x + 7.5f as the maximum and a maxY */
			Instantiate (coin, x, Random.rotation); // This is where we Instantiate the coin with the given values (Prefab, Position, and its random.rotation
		}
		yield return new WaitForSeconds (2); //Here we make a timer too wait 2 seconds before activating the code again. 
		StartCoroutine (Spawn()); // Starting the code again 
	}



}
