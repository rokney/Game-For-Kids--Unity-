using UnityEngine;
using System.Collections;

public class BackMusic: MonoBehaviour {
	public static BackMusic instance = null;

	// Use this for initialization
	void Start () {
        if(instance!=null){
			Destroy(gameObject);
			Debug.Log ("One Music Destroyed");
            return;
        }
	    instance = this;
        DontDestroyOnLoad (gameObject);
        //if(GlobalOptions.isSound()){
            GetComponent<AudioSource>().Play();
        //}\

	}
    
    public void Pause(){
		GetComponent<AudioSource>().Pause();
    }
    
    public void Play(){
		GetComponent<AudioSource>().Play();
    }
}
