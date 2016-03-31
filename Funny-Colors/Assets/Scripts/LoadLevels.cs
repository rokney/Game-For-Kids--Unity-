using UnityEngine;
using System.Collections;

public class LoadLevels : MonoBehaviour
{
	public bool Home = false;
	public bool lvl1 = false;
	public bool lvl2 = false;
	public bool lvl3 = false;
	public bool lvl4 = false;
	public bool lvl5 = false;
	public bool lvl6 = false;
	public bool lvl7 = false;
	public bool lvl8 = false;
	public bool lvl9 = false;
	public bool lvl10 = false;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Pressed ()
	{
		if (Home == true) {
			Application.LoadLevel (0);
		}
		if (lvl1 == true) {
			Application.LoadLevel ("lvl1");
		}
		if (lvl2 == true) {
			Application.LoadLevel ("lvl2");
		}
		if (lvl3 == true) {
			Application.LoadLevel ("lvl3");
		}
		if (lvl4 == true) {
			Application.LoadLevel ("lvl4");
		}
		if (lvl5 == true) {
			Application.LoadLevel("lvl5");
		}
		if (lvl6 == true) {
			Application.LoadLevel("lvl6");
		}
		if (lvl7 == true) {
			Application.LoadLevel("lvl7");
		}
		if (lvl8 == true) {
			Application.LoadLevel("lvl8");
		}
		if (lvl9 == true) {
			Application.LoadLevel("lvl9");
		}

	}
}
