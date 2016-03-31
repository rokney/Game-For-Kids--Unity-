using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{

	static int currentTrek;
	int numberTrek;
	public bool Next = false;
	public bool Prev = false;
	public bool _Play = false;
	public bool _Stop = false;
	public static AudioSource pleer;
	public AudioClip[] treks;

	void Awake ()
	{
		pleer = GameObject.Find ("Music").GetComponent<AudioSource> ();
		currentTrek = 0;
		numberTrek = treks.Length - 1;
	}

	public void Pressed ()
	{
		if (Next == true) {
			if (currentTrek + 1 <= numberTrek) {
				currentTrek++;
				SelectTrek (currentTrek);
				pleer.Play ();
			} else {
				currentTrek = 0;
				SelectTrek (currentTrek);
				pleer.Play ();
			}
		}
		if (Prev == true) {
			if (currentTrek - 1 >= 0) {
				currentTrek--;
				SelectTrek (currentTrek);
				pleer.Play ();
			} else {
				currentTrek = numberTrek;
				SelectTrek (currentTrek);
				pleer.Play ();
			}
		}
		if (_Play == true) {
			pleer.Play ();
		}
		if (_Stop == true) {
			pleer.Pause ();
		}
	}

	void SelectTrek (int index)
	{
		for (int cnt = 0; cnt < treks.Length; cnt++) {
			if (cnt == index) {
				pleer.clip = treks [cnt];
			}
		}
	}

}
