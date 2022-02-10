using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AmbienceControl : MonoBehaviour {




	//public bool isPlaying;
	public AudioSource ambience;

	void Update() {
		
	}

	void Start () {
		ambience = Camera.main.gameObject.GetComponent<AudioSource>();	
		// isPlaying = false;
	}
	

	public void PauseAmbience() {
		ambience.Pause();
	}

	public void ResumeAmbience() {
		ambience.UnPause();
	}


}
