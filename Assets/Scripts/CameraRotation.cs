using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
    // Use this for initialization
   // Camera camera;
    public float rotationSpeed = 1.5f;

    void Start () {
       // camera = GetComponentInChildren <Camera>();
        
    }
	
	// Update is called once per frame
	void Update () {
        
        float mouseX = rotationSpeed * Input.GetAxis("Mouse X");
        //float mouseY = rotationSpeed * Input.GetAxis("Mouse Y");
        transform.rotation =  Quaternion.Euler(0, mouseX, 0) * transform.rotation;
       // camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;
    }
}
