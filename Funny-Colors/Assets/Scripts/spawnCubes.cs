using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class spawnCubes : MonoBehaviour
{
	public Transform[] spawnPoints;
	public GameObject[] cubes;
	private GameObject obj;
	// Use this for initialization
	void Start ()
	{
		 // Randomize the different enemies to instantiate.
		for (int i = 0; i < spawnPoints.Length; i++) {

			if(Random.value > 0.5){
				obj = cubes [0];
			}
			else{
				obj = cubes [Random.Range (1, cubes.Length)];
			}
			//GameObject obj = cubes [Random.Range (0, cubes.Length)];
			Transform pos = spawnPoints [i];
			Instantiate (obj, pos.position, pos.rotation); 
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
		
}
