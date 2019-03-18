using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerDisplay : MonoBehaviour
{
    BallLauncher launcher;
    public RawImage power;
    private float max = 100;
    // Use this for initialization
    void Start()
    {
        launcher = FindObjectOfType<BallLauncher>();
    }
    void Update()
    {
        if (launcher.launched == false)
        {
            float ratio = launcher.ballSpeed / max;
            power.rectTransform.localScale = new Vector3(1, ratio, 1);
        }
        else launcher.ballSpeed = 0;
    }
}
