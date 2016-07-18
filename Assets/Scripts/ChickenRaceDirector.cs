using UnityEngine;
using System.Collections;
using UnityEngine.UI;

class ChickenRaceDirector : MonoBehaviour {

    public GameObject runner;
    public GameObject goalSign;
    public GameObject distance;

    void Update () {
        float length = this.goalSign.transform.position.x - this.runner.transform.position.x;
        this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
    }
}
