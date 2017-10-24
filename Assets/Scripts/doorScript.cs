using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {


	public bool wasVisited = false;
	private gameManager gm;
	public int randNum;
	public int lastRandNum;
	private visualFeedback vfb;

	void Awake (){
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
		vfb = GameObject.FindGameObjectWithTag ("VisualFeedback").GetComponent<visualFeedback> ();
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
			vfb.CandyEffect ();
		}else{
			//Code for ghost here
			Debug.Log ("Trick! No candy... :(");
			gm.addGhost ();
			vfb.GhostEffect ();
		}

		wasVisited = true;
	}
}

