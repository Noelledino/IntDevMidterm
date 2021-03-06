﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public string mainMenu;
	public string restart;

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	private gameManager gm;

	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void Update () {
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}

	}


	public void unPause(){
		isPaused = false;
	}

	public void RestartGame(){
		gm.Restart ();
		SceneManager.LoadScene (restart);
	}

	public void ReturnMenu (){
		SceneManager.LoadScene (mainMenu);
	}
}
