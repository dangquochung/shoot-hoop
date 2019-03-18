using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WC2 : MonoBehaviour {
	public static Transform[] points_C2;
	// Use this for initialization
	void Awake () {
		points_C2 =new Transform[transform.childCount];
		for (int i = 0; i < points_C2.Length; i++) {
			points_C2[i] = transform.GetChild(i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
