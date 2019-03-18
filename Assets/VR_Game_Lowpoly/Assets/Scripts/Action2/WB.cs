using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WB : MonoBehaviour {
	public static Transform[] points_B;
	// Use this for initialization
	void Awake () {
		points_B =new Transform[transform.childCount];
		for (int i = 0; i < points_B.Length; i++) {
			points_B[i] = transform.GetChild(i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
