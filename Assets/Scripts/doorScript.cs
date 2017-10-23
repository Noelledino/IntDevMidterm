using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {


	public bool wasVisited = false;
	private gameManager gm;

	void Awake (){
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	void Update(){

	}
	public void TrickOrTreat(){
		int randNum = (int)Random.Range(0, 2);
		Debug.Log (randNum);
		if(randNum == 0){
			//Code for treat here
			Debug.Log ("Treat! Player Gets some candy!");		
			gm.points += 1;

		}else{
			//Code for ghost here
			Debug.Log ("Trick! No candy... :(");
		}

		wasVisited = true;
	}
}

