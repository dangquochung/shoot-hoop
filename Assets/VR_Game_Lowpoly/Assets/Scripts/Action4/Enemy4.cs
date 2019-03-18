using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : MonoBehaviour {
    public GameObject levelManager;
    public float speed =10f;
	private Transform target;
	private int wavepoint_D_Index=0;
	void Start(){
		target = WD.points_D [0];
	}

	void Update(){
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime , Space.World);

		if(Vector3.Distance(transform.position,target.position)<=0.4f ){
			GetNextWaypoint_D ();
		}
	}
	void GetNextWaypoint_D(){
		if(wavepoint_D_Index >= WD.points_D.Length - 1){
            levelManager.GetComponent<LevelManager>().health--;
            Destroy (gameObject);
			return;
		}
		wavepoint_D_Index++;
		target = WD.points_D [wavepoint_D_Index];

	}
}

