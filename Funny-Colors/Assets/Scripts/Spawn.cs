using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Spawn : MonoBehaviour
{
	public GameObject _ContextMenu;
	private Text _text, _text2;
	public static int count, count2;
	public Transform[] spawnPoints;
	public GameObject[] cubes;
	public int numCubes;
	public int yielTimeMin;
	public int yielTimeMax;
	private GameObject obj;
	// Use this for initialization
	void Start ()
	{
		_text = GameObject.Find ("Count").GetComponent<Text> ();
		_ContextMenu.SetActive (false);
		StartCoroutine (spawn ());
	}

	void Awake ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			RaycastHit2D _hit = Physics2D.GetRayIntersection (ray);
			if (_hit.collider != null) {
				if (_hit.transform.tag == "true_cube") {
					if (count < 10) {
						count++;
						Destroy (_hit.transform.gameObject);
						_text.text = count.ToString () + " / 10";
					} else
						return;
				}

			}
			
		}
		if (count == 10) {
			StopAllCoroutines ();
			_ContextMenu.SetActiveRecursively (true);
			count = 0;
		}

	}

	IEnumerator spawn ()
	{
		for (int i=0; i<numCubes; i++) {
			yield return new WaitForSeconds (Random.Range (yielTimeMin, yielTimeMax));  // How long to wait before another enemy is instantiated.
			if(Random.value > 0.45){
				obj = cubes[0];
			}
			else {
			obj = cubes [Random.Range (1, cubes.Length)];
			}// Randomize the different enemies to instantiate.
			Transform pos = spawnPoints [Random.Range (0, spawnPoints.Length)];  // Randomize the spawnPoints to instantiate enemy at next.
			
			Instantiate (obj, pos.position, pos.rotation); 
			if(i == numCubes-1){
				i=0;
			}
		}

	}


}
