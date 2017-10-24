using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endstateScript : MonoBehaviour {

	public GameObject player;
	public GameObject ghostEffect;
	public GameObject GameOverScreen;
	public GameObject YouWinScreen;
	private gameManager gm;

	private bool canPlay = true;


	// Use this for initialization
	void Start () {
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gm.housesVisited != 6 && gm.ghostCount >= 3) {
			GameOver ();
		} else if (gm.housesVisited >=6 && gm.ghostCount >=3) {
			YouWin ();

		}
		if (gm.housesVisited >= 6 && gm.ghostCount <= 3) {
			YouWin ();
		}
		if (gm.housesVisited <= 0) {
			canPlay = true;
		}

	}

	public void GameOver() {
		GameOverScreen.SetActive (true);
		player.gameObject.SetActive (false);
		ghostEffect.SetActive (true);
		if (canPlay) {
			canPlay = false;
			GameOverScreen.GetComponent<AudioSource> ().Play ();
		}
	}

	public void YouWin () {
		YouWinScreen.SetActive (true);
		player.gameObject.SetActive (false);
		if (canPlay) {
			canPlay = false;
			YouWinScreen.GetComponent<AudioSource> ().Play ();
		}
	}

}
