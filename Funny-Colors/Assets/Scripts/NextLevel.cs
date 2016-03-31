using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour
{
	public bool chLevel = false;
	private string [] lvlName = new string[] {"lvl1", "lvl2","lvl3", "lvl4","lvl5", "lvl6","lvl7", "lvl8","lvl9", "lvl10"};
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));
			RaycastHit2D _hit = Physics2D.GetRayIntersection (ray);
			if (_hit.collider != null) {

				if (_hit.transform.tag == "Repeat") {
					/*if(Application.loadedLevelName == "lvl1"){
					Application.LoadLevel ("lvl1");
					}
					if(Application.loadedLevelName == "lvl2"){
						Application.LoadLevel ("lvl2");
					}
					if(Application.loadedLevelName == "lvl3"){
						Application.LoadLevel("lvl3");
					}
					if(Application.loadedLevelName == "lvl4"){
						Application.LoadLevel("lvl4");
					}
					if(Application.loadedLevelName == "lvl5"){
						Application.LoadLevel("lvl5");
					}
					if(Application.loadedLevelName == "lvl6"){
						Application.LoadLevel("lvl6");
					}
					if(Application.loadedLevelName == "lvl7"){
						Application.LoadLevel("lvl7");
					}
					if(Application.loadedLevelName == "lvl8"){
						Application.LoadLevel("lvl8");
					}*/
					Application.LoadLevel(Application.loadedLevelName);
				}
				if (_hit.transform.tag == "Menu") {
					Application.LoadLevel (2);
				}
				if (_hit.transform.tag == "Next") {
					for(int i = 0; i < lvlName.Length-1; i++){
						if(Application.loadedLevelName == lvlName[i]){
							Application.LoadLevel(lvlName[i+1]);
						}
					}
				}
			}
		}
	}

	public void ChangeLevel ()
	{
		if (chLevel == true) {
			Application.LoadLevel (2);
			Spawn.count = 0;
			Spawn2.count = 0;
			Spawn2.count2 = 0;
			Spawn3.count = 0;
			Spawn3.count2 = 0;
			Spawn3.count3 = 0;

		}
	}

}
