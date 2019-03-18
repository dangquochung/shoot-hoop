using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WC1 : MonoBehaviour {
	public static Transform[] points_C1;
	// Use this for initialization
	void Awake () {
		points_C1 =new Transform[transform.childCount];
		for (int i = 0; i < points_C1.Length; i++) {
			points_C1[i] = transform.GetChild(i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
