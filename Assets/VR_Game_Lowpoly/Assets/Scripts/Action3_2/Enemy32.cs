using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy32 : MonoBehaviour {
    public GameObject levelManager;
    public float speed =10f;
	private Transform target;
	private int wavepoint_C2_Index=0;
	void Start(){
		target = WC2.points_C2 [0];
	}

	void Update(){
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime , Space.World);

		if(Vector3.Distance(transform.position,target.position)<=0.4f ){
			GetNextWaypoint_C2 ();
		}
	}
	void GetNextWaypoint_C2(){
		if(wavepoint_C2_Index >= WC2.points_C2.Length - 1){
            levelManager.GetComponent<LevelManager>().health--;
            Destroy (gameObject);
			return;
		}
		wavepoint_C2_Index++;
		target = WC2.points_C2 [wavepoint_C2_Index];

	}
}

