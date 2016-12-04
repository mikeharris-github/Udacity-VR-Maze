using UnityEngine;
using System.Collections;

public class DetectKey : MonoBehaviour {

	public Animator keyAnim; // this is to trigger the key animation
	bool watched = false;

	void FixedUpdate() 
	{
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Physics.Raycast(transform.position, fwd, 5)) 
			keyAnim.SetBool("OpenBool",true);
			watched = true;
			print ("Key!");
	}
}
