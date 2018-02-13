using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour {

    GameObject scorePoint;
    int point = 0;

    public void SmallStarPrefab() {
        this.point += 10;
    }
    public void LargeStarPrefab(){
        this.point += 50;
    }
    public void SmallCloudPrefab(){
        this.point += 30;
    }
    public void LargeCloudPrefab(){
        this.point += 100;
    }

	// Use this for initialization
	void Start () {
        this.scorePoint = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
        this.scorePoint.GetComponent<Text>().text =
                "Score : " + this.point.ToString();
	}
}
