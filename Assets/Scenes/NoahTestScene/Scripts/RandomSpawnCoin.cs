using UnityEngine;
using System.Collections;

public class RandomSpawnCoin : MonoBehaviour {
	[SerializeField]
	private Transform _player; 
	[SerializeField]
	private Transform _coin;
	[SerializeField]
	private float _minX;
	[SerializeField]
	private float _maxX;
	[SerializeField]
	private float _minY = 0.5f;
	[SerializeField]
	private float _maxY = 1.0f;
	private float _minZ = 0.0f;
	private float _maxZ = 0.0f;
	[SerializeField]
	private int maxCoins = 5;



	void Start(){
		StartCoroutine (Spawn()); // Begin IEnumerator Spawn 

	}


	IEnumerator Spawn(){
		for (int i = 0; i < maxCoins; i++) { //The int named i = 0 if i is lower the value in maxCoins its getting a coin
			Vector3 x = new Vector3 (Random.Range(_player.position.x+5f, _player.position.x+7.5f), Random.Range(_player.position.y+1.0f,_player.position.y+2.0f)); /*
			Making a new vector 3 and naming it x saying it can place its coins between 2 x axis. In this case its the player.position.x + 5f as the minimum and 
			player.position.x + 7.5f as the maximum and a maxY */
			Instantiate (_coin, x, Random.rotation); // This is where we Instantiate the coin with the given values (Prefab, Position, and its random.rotation
		}
		yield return new WaitForSeconds (2); //Here we make a timer too wait 2 seconds before activating the code again. 
		StartCoroutine (Spawn()); // Starting the code again 
	}



}
