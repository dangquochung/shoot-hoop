using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallLauncher : MonoBehaviour {
    public AudioClip sound;
    private AudioSource source;
    public float vol=1f;

    public GameObject ballPrefabs;
    public float ballSpeed = 0.0f;
    float fireRate = 0.5f;
    int check = 0;
    public bool launched = false;
    public Text text;
    // Use this for initialization
    void Start () {
        
	}
    // Update is called once per frame
    void Update () {
        source = GetComponent<AudioSource>();
        Camera camera = GetComponentInChildren<Camera>();
        Vector3 v = camera.transform.rotation * Vector3.forward * ballSpeed * 200000;
        float x = v.x, y = v.y, z = v.z;
        float angleR = Mathf.Asin(y/Mathf.Sqrt(x*x+y*y+z*z));
        double angleD = angleR * 180 / 3.14;
        if (x*x + y*y + z*z != 0)
        text.text = "" + (angleD - angleD % 1);

        if (ballSpeed >= 100) check = 1;
        if (ballSpeed <= 0) check = 0;
        if (check == 0) ballSpeed += Time.deltaTime * 20;
        else ballSpeed -= Time.deltaTime * 20;

        fireRate -= Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && fireRate <= 0)
        {
            launched = true;
            GameObject instance = Instantiate(ballPrefabs);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            source.PlayOneShot(sound, vol);
            rb.AddForce(v);
            fireRate = 0.5f;
        }
    }
}
