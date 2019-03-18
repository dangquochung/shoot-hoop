using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy31 : MonoBehaviour {
    public GameObject levelManager;
    public float speed =10f;
	private Transform target;
	private int wavepoint_C1_Index=0;
	void Start(){
		target = WC1.points_C1 [0];
	}

	void Update(){
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime , Space.World);

		if(Vector3.Distance(transform.position,target.position)<=0.4f ){
			GetNextWaypoint_C1 ();
		}
	}
	void GetNextWaypoint_C1()
    {
        if (wavepoint_C1_Index >= WC1.points_C1.Length - 1)
        {
            levelManager.GetComponent<LevelManager>().health--;
            Destroy(gameObject);
            return;
        }
        wavepoint_C1_Index++;
        target = WC1.points_C1[wavepoint_C1_Index];

    }
}

