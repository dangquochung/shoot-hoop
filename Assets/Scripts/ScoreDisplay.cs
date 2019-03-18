using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    Text text;
    ScoreKeeper display;
    // Use this for initialization
    void Start () {
        display = FindObjectOfType<ScoreKeeper>();
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "SCORE: "+display.score;
	}
}
