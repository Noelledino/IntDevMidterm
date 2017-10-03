using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public int points;
	public Text pointsText;

	void Start () {
	}

	void Update () {

		pointsText.text = ("" + points + " candy");
	}
}
