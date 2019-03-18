using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WE : MonoBehaviour {
	public static Transform[] points_E;
	// Use this for initialization
	void Awake () {
		points_E =new Transform[transform.childCount];
		for (int i = 0; i < points_E.Length; i++) {
			points_E[i] = transform.GetChild(i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
