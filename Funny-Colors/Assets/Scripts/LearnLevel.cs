using UnityEngine;
using System.Collections;

public class LearnLevel : MonoBehaviour
{
	public bool Next = false;
	public bool Prev = false;
	public bool Home = false;
	public GameObject[] goColors;
	static int currGOIndex;

	// Use this for initialization
	void Start ()
	{
		currGOIndex = 0;
		for (int i=1; i<goColors.Length; i++) {
			goColors [i].SetActive (false);
		}
		if (goColors.Length > 0) {
			goColors [0].SetActive (true);
			
		}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Pressed ()
	{ 
		if (Next == true) {
			currGOIndex++;

			if (currGOIndex < goColors.Length) {
				goColors [currGOIndex - 1].SetActive (false);
				goColors [currGOIndex].SetActive (true);
				
			} else {
				goColors [currGOIndex - 1].SetActive (false);
				currGOIndex = 0;
				goColors [currGOIndex].SetActive (true);
				
			}
		}
		if (Prev == true) {
			currGOIndex--;

			if (currGOIndex >= 0) {
				goColors [currGOIndex + 1].SetActive (false);
				goColors [currGOIndex].SetActive (true);
				
			} else {
				goColors [currGOIndex + 1].SetActive (false);
				currGOIndex = goColors.Length - 1;
				goColors [currGOIndex].SetActive (true);
			}
		}
		
		if (Home == true) {
			Application.LoadLevel (0);
		}
		
	}

}
