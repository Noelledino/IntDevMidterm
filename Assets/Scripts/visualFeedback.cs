using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualFeedback : MonoBehaviour {

	public GameObject ghostEffect;
	public GameObject candyEffect;
	public AudioClip candy;
	public AudioClip ghost;

	IEnumerator candyWait(){
		candyEffect.gameObject.SetActive (true);
		yield return new WaitForSeconds (3f);
		candyEffect.gameObject.SetActive (false);
	}

	IEnumerator ghostWait(){
		ghostEffect.gameObject.SetActive (true);
		yield return new WaitForSeconds (3f);
		ghostEffect.gameObject.SetActive (false);
	}

	void Start () {
		candyEffect.gameObject.SetActive (false);
		ghostEffect.gameObject.SetActive (false);
	
	}

	public void CandyEffect () {

		AudioSource ourAudio = GetComponent<AudioSource> ();
		ourAudio.PlayOneShot (candy);
		StartCoroutine (candyWait ());

	}

	public void GhostEffect () {

		AudioSource ourAudio = GetComponent<AudioSource> ();
		ourAudio.PlayOneShot (ghost);
		StartCoroutine (ghostWait ());

	}





}
