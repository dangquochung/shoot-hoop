using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public float damage = 0f;
    BallLauncher launcher;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        launcher = FindObjectOfType<BallLauncher>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
        damage += Time.deltaTime*30;
        //transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        launcher.launched = false;
    }
}
