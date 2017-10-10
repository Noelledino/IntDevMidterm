using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public static gameManager instance = null;

	public int points;
	public Text pointsText;

	void Awake () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);
		} else if ( instance != this){
			Destroy (gameObject);
		}
	}

	void Update () {

		pointsText.text = ("" + points + " candy");
	}
}
