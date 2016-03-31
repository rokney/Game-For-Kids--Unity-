using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public bool Play = false;
	public bool Settings = false;
	public bool Quit = false;
	public bool Back = false;
	public bool Learn = false;
	public bool Play_Levels = false;
	public Camera camera1, camera2, camera3;

	// Use this for initialization
	void Start () {
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void Change(){
		if (Play == true) {
			camera3.enabled = true;
			camera1.enabled = false;
		}
		if (Settings == true) {
			camera2.enabled = true;
			camera1.enabled = false;
		}
		if (Quit == true) {
			Application.Quit ();
		}
		if (Back == true) {
			camera1.enabled = true;
			if(camera3.enabled == true){
				camera3.enabled = false;}
			if(camera2.enabled == true){
				camera2.enabled = false;}

		}
		if (Learn == true) {
			Application.LoadLevel (1);
		}
		if (Play_Levels == true) {
			Application.LoadLevel (2);
		}
	}
		
}
