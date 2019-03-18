using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour {
    public AudioClip Crash;

    private GvrAudioSource source;
	// Use this for initialization
	void Awake () {
        source = GetComponent<GvrAudioSource>();
	}
	
	
	void OnCollisionEnter (Collision coll) {

        source.PlayOneShot(Crash, 1F);
	}
}
