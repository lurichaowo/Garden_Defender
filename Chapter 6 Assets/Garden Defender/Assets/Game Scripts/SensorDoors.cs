using UnityEngine;
using System.Collections;

public class SensorDoors : MonoBehaviour {
	
	public AnimationClip clipOpen; // the open animation
	public AnimationClip clipClose; // the close animation

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// open the gates
	void OnTriggerEnter (Collider defender) {
	   if (defender.gameObject.tag == "Player") {
	      GetComponent<Animation>().Play(clipOpen.name);
		  GetComponent<AudioSource>().Play(); // play the clip loaded in the audio component	
	   }
	}

	// close the gates
	void OnTriggerExit (Collider defender) {
	   if (defender.gameObject.tag == "Player") {
	      GetComponent<Animation>().Play(clipClose.name);
		  GetComponent<AudioSource>().Play(); // play the clip loaded in the audio component
	   }
	}

}
