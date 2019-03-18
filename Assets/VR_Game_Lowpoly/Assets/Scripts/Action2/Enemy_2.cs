using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : MonoBehaviour {
    public GameObject levelManager;
	public float speed =10f;
	private Transform target;
	private int wavepoint_B_Index=0;
	void Start(){
		target = WB.points_B [0];
	}

	void Update(){
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime , Space.World);

		if(Vector3.Distance(transform.position,target.position)<=0.4f ){
			GetNextWaypoint_B ();
		}
	}
	void GetNextWaypoint_B(){
		if(wavepoint_B_Index >= WB.points_B.Length - 1){
            levelManager.GetComponent<LevelManager>().health--;
			Destroy (gameObject);
			return;
		}
		wavepoint_B_Index++;
		target = WB.points_B [wavepoint_B_Index];

	}
}

