using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {
    public int scoreMultiple = 1;
    public float health = 5;
	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame

    void Update()
    {
        
        // health += Time.deltaTime * 5;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bullet"))
        {
            health -= collision.collider.GetComponent<Brick>().damage;
            //GetComponentInParent<ScoreKeeper>().score++;
        }
        if (health <= 0) DestroyObject(this.gameObject);
    }
}
