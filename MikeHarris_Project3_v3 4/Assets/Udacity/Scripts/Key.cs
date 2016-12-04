using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	public GameObject key;
	public ParticleSystem KeyPoofPrefab;
	public GameObject door;
	public AudioClip clip;
	public bool haveKey = false;

    //Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located. RAYCAST!!!
		Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90,0,0));
        // Make sure the poof animates vertically
		AudioSource.PlayClipAtPoint(clip, transform.position); //PlayClipAtPoint is a Class
        // Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();
		// Check haveKey boolean to True
		haveKey = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (key);

    }

}
