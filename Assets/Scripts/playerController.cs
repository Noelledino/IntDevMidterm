using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	Vector3 inputVector; // take input from Update, and send it into FixedUpdate for physics
//	private gameManager gm;
	private doorScript door;

	public Text endText;

	void Awake (){
//		gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<gameManager>();
		door = GameObject.FindGameObjectWithTag ("Door").GetComponent<doorScript>();
	}

	// Update is called once per frame
	void Update () {
		// grab input for this frame
		float horizontalInput = Input.GetAxis ("Horizontal"); // A/D, LeftArrow/RightArrow
		float verticalInput = Input.GetAxis ("Vertical"); // W/S, UpArrow/DownArrow

		// transform our input values based on this transform's "right" / "forward" directions
		inputVector = transform.right * horizontalInput + transform.forward * verticalInput;

		transform.Rotate (0f, horizontalInput * Time.deltaTime * 90f, 0f);

		// normalize the inputVector so that diagonal movement isn't faster
		if (inputVector.magnitude > 1f) {
			inputVector = Vector3.Normalize (inputVector);
		}

	
		//Here's the script for checking if a door is there
		Ray shootRay = new Ray (transform.position, transform.forward);
		float maxRayDistance = 20f;
		Debug.DrawRay (shootRay.origin, shootRay.direction*10, Color.yellow);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Is the player near a door? Raycast Fired!");
			RaycastHit shootRayHit = new RaycastHit ();

			if (Physics.Raycast (shootRay, out shootRayHit, maxRayDistance) && shootRayHit.collider.gameObject.tag == "Door") {
				//The Ray hit the door!! Now we can do stuff!!!
				Debug.Log ("A door was hit!");
				door = shootRayHit.transform.GetComponent<doorScript> ();

				if (door.wasVisited == false) {
					door.TrickOrTreat ();
				}
			} else {
				Debug.Log ("No door was hit. :(");
			}
		}


	}

	// FixedUpdate is called once per physics frame
	void FixedUpdate () {
		// if( inputVector.magnitude > 0.001f ) {
		GetComponent<Rigidbody>().velocity = inputVector * 30f + Physics.gravity * 0.62f;
		// } 
	}

	}

//	void OnTriggerEnter (Collider col) {
//		if (col.CompareTag ("Candy")) {
//			Destroy (col.gameObject);
//			gm.points += 1;
//		}
//	}