using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WD : MonoBehaviour {
	public static Transform[] points_D;
	// Use this for initialization
	void Awake () {
		points_D =new Transform[transform.childCount];
		for (int i = 0; i < points_D.Length; i++) {
			points_D[i] = transform.GetChild(i);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
