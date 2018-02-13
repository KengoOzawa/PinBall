using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {


    // ボールが見える可能性があるZ軸の最大値
    private float visiblePosZ = -6.5f;

    // ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // 宣言(加筆部分)
    GameObject director;

	// Use this for initialization
	void Start () {

        //ScoreDirectorを取得 (加筆部分)
        this.director = GameObject.Find("ScoreDirector");

        // シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
	}
	
    // それぞれのオブジェクトとぶつかったとき対応する関数を呼び出す(加筆部分)
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SmallStarPrefab")
        {
            this.director.GetComponent<ScoreDirector>().SmallStarPrefab();
        }
        else if (other.gameObject.tag == "largeStarPrefab")
        {
            this.director.GetComponent<ScoreDirector>().LargeStarPrefab();
        }
        else if (other.gameObject.tag == "SmallCloudPrefab")
        {
            this.director.GetComponent<ScoreDirector>().SmallCloudPrefab();
        }
        else if (other.gameObject.tag == "LargeCloudPrefab")
        {
            this.director.GetComponent<ScoreDirector>().LargeCloudPrefab();
        }
    }

	// Update is called once per frame
	void Update () {

        // ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ) {
            // GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
		
	}
}
