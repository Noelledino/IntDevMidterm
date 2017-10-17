using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class doorScript : MonoBehaviour {
	
	private gameManager gm;

	void Awake (){
		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager> ();
	}

	public void TrickOrTreat(){
//		int randNum;
//		randNum = Mathf.Random.Range((int)0, (int)1);
//		if(randNum == 0){
//			//Code for treat here
//			Debug.Log ("Treat! Player Gets some candy!");		
//			gm.points += 1;
//
//		}else{
//			//Code for ghost here
//			Debug.Log ("Trick! No candy... :(");
//		}
	}
}

