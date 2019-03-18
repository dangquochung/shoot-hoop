using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
    public GameObject ballPrefabs;
    Rigidbody rb;
    // Use this for initialization
    void Start () {
        
	}
    void Spawn()
    {
        GameObject instance = Instantiate(ballPrefabs);
        rb = instance.GetComponent<Rigidbody>();
        instance.transform.position = transform.position;
    }
	// Update is called once per frame
	void Update () {
        float velocity = 150.0f;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            Spawn();
            rb.velocity = Vector3.left * velocity;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Spawn();
            rb.velocity = Vector3.right * velocity;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Spawn();
            rb.velocity = Vector3.forward * velocity;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Spawn();
            rb.velocity = Vector3.back * velocity;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn();
            rb.velocity = Vector3.up * velocity;
        }
    }
}
