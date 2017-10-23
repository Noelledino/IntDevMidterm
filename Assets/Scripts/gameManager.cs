using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public static gameManager instance = null;

	public int housesVisited;
//	private doorScript door;
//	public int points;
//	public Text pointsText;

	public Image checkmark1;
	public Image checkmark2;
	public Image checkmark3;
	public Image checkmark4;
	public Image checkmark5;
	public Image checkmark6;	

	public Image candy1;
	public Image candy2;
	public Image candy3;
	public Image candy4;
	public Image candy5;
	public Image candy6;	

	public Image ghost1;
	public Image ghost2;
	public Image ghost3;
	public Image ghost4;
	public Image ghost5;
	public Image ghost6;

	void Awake () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else if ( instance != this){
			Destroy (gameObject);
		}
//		door = GameObject.FindGameObjectWithTag ("Door").GetComponent<doorScript> ();

		housesVisited = 0;

		//an incoming disaster
		checkmark1.enabled = false;
		checkmark2.enabled = false;
		checkmark3.enabled = false;
		checkmark4.enabled = false;
		checkmark5.enabled = false;
		checkmark6.enabled = false;

		ghost1.enabled = false;
		ghost2.enabled = false;
		ghost3.enabled = false;
		ghost4.enabled = false;
	 	ghost5.enabled = false;
		ghost6.enabled = false;

		candy1.enabled = false;
		candy2.enabled = false;
		candy3.enabled = false;
		candy4.enabled = false;
		candy5.enabled = false;
		candy6.enabled = false;
	}

	void Update () {
		if (housesVisited == 1) {
			checkmark1.enabled = true;
		}
		if (housesVisited == 2) {
			checkmark2.enabled = true;
		}
		if (housesVisited == 3) {
			checkmark3.enabled = true;
		}
		if (housesVisited == 4) {
			checkmark4.enabled = true;
		}
		if (housesVisited == 5) {
			checkmark5.enabled = true;
		}
		if (housesVisited == 6) {
			checkmark6.enabled = true;
		}

//		pointsText.text = ("" + points + " candy");
	}
	public void addGhost () {
		if (housesVisited == 1) {
			ghost1.enabled = true;
		}
		if (housesVisited == 2) {
			ghost2.enabled = true;
		}
		if (housesVisited == 3) {
			ghost3.enabled = true;
		}
		if (housesVisited == 4) {
			ghost4.enabled = true;
		}
		if (housesVisited == 5) {
			ghost5.enabled = true;
		}
		if (housesVisited == 6) {
			ghost6.enabled = true;
		}
	}

	public void addCandy () {
		if (housesVisited == 1) {
			candy1.enabled = true;
		}
		if (housesVisited == 2) {
			candy2.enabled = true;
		}
		if (housesVisited == 3) {
			candy3.enabled = true;
		}
		if (housesVisited == 4) {
			candy4.enabled = true;
		}
		if (housesVisited == 5) {
			candy5.enabled = true;
		}
		if (housesVisited == 6) {
			candy6.enabled = true;
		}
	}
}