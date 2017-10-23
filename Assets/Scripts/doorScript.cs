using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {


	public bool wasVisited = false;
	private gameManager gm;
	public int randNum;
	public int lastRandNum;

	void Awake (){
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();

	}

	void Update(){

	}
	public void TrickOrTreat(){
		gm.housesVisited++;
		int randNum = (int)Random.Range(0, 2);
		lastRandNum = randNum;
		Debug.Log (randNum);
		if(randNum == 0){
			//Code for treat here
			Debug.Log ("Treat! Player Gets some candy!");
			gm.addCandy ();
		}else{
			//Code for ghost here
			Debug.Log ("Trick! No candy... :(");
			gm.addGhost ();
		}

		wasVisited = true;
	}
}

