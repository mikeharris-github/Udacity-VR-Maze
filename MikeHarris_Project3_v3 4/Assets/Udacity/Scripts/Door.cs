using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	// Create a boolean value called "locked" that can be checked in Update() 
	public GameObject openDoor;
	float startTime = 0f;
	public AudioClip clip;
	bool isPressed = false;
	bool Unlocked = false;
	public GameObject youWin;
	public GameObject DoorHolder;

	void Start ()
	{
		youWin.SetActive(false);
	}

	void Update() {
		Quaternion startRotation = Quaternion.Euler (0f, 0f, 0f);	// defines the start rotation transform.
		Quaternion endRotation = startRotation * Quaternion.Euler (0f, 90f, 0f);	// defines the end rotation transform.

		if (isPressed && !Unlocked) {
			Debug.Log ("You still need to get the key.");
			isPressed = false;	// this makes sure the door becomes locked again.
		}
		if (isPressed && Unlocked == true) {
			DoorHolder.transform.rotation = Quaternion.Slerp (startRotation, endRotation, startTime / .5f);
			startTime += Time.deltaTime;
			AudioSource.PlayClipAtPoint(clip, transform.position); //PlayClipAtPoint is a Class
			youWin.SetActive (true);
		}
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
    }

    public void Unlock() {

		Unlocked = true;
		Debug.Log ("Booyah! The door is now unlocked.");
        // You'll need to set "locked" to true here
    }

	public void ActivateRotation() {
		isPressed = true;	// this will activate the rotation of the door
	}
}
