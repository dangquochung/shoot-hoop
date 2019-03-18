using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5 : MonoBehaviour {
    public GameObject levelManager;
    public float speed =10f;
	private Transform target;
	private int wavepoint_E_Index=0;
	void Start(){
		target = WE.points_E [0];
	}

	void Update(){
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime , Space.World);

		if(Vector3.Distance(transform.position,target.position)<=0.4f ){
			GetNextWaypoint_E ();
		}
	}
	void GetNextWaypoint_E(){
		if(wavepoint_E_Index >= WE.points_E.Length - 1){
            levelManager.GetComponent<LevelManager>().health--;
            Destroy (gameObject);
			return;
		}
		wavepoint_E_Index++;
		target = WE.points_E [wavepoint_E_Index];

	}
}

