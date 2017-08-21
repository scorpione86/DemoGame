using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGUI : MonoBehaviour {

    public Text scoreText;

	// Use this for initialization
	void Start () {

        scoreText.text = "SCORE: " + GameMaster.finalScore.ToString();

    }

}
