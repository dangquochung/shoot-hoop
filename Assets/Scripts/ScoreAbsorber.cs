using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAbsorber : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
        ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        score = 1;
        if (oldKeeper) {
            score = oldKeeper.score;
            Destroy(oldKeeper.gameObject);
        }
        Text text;
        text = GetComponent<Text>();
        text.text = "SCORE: " + score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
