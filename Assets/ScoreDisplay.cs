using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    Text scoreDisplay;

    private void Start()
    {
        scoreDisplay = gameObject.GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        int playerScore = GameObject.Find("Basket").GetComponent<Goal>().scoreCount; 
        scoreDisplay.text = "Score: " + playerScore;
    }
}
