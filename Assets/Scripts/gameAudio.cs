using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameAudio : MonoBehaviour {

		static bool AudioBegin = false; 

		void Awake()

		{
			AudioBegin = false;
			if (!AudioBegin) {
				AudioSource audio = GetComponent<AudioSource> ();
				audio.loop = true; // make sure it's looping
				if( audio.isPlaying ) {
					audio.Stop(); // stop the audio if it's already playing a sound
				} else {
					audio.Play(); // start the audio if it's not already playing
				}
				AudioBegin = true;
			} 
		}
		void Update () {
			if(SceneManager.GetActiveScene().name == "mainMenu")
			{
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Stop();
				AudioBegin = false;
			}
		}
	}