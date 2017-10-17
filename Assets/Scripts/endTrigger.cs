using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endTrigger : MonoBehaviour {

	public Text endText;

	// Use this for initialization
	void OnTriggerEnter (Collider activator) {
			Debug.Log ("Player ended game");
			endText.text = ("OK THE GAME IS OVER FOR NOW");
	}
}
