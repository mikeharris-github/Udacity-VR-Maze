using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject CoinObject;
	public ParticleSystem CoinPoof;
	public AudioClip clip;
	//Create a reference to the CoinPoofPrefab


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Instantiate(CoinPoof, transform.position, Quaternion.Euler(-90,0,0));
        // Make sure the poof animates vertically
		AudioSource.PlayClipAtPoint(clip, transform.position); //PlayClipAtPoint is a Class
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (CoinObject);
    }

}
