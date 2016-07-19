using UnityEngine;
using System.Collections;
using UnityEngine.UI;

class ChickenRaceDirector : MonoBehaviour
{

    [SerializeField] Transform runner;
    [SerializeField] Transform goalSign;
    [SerializeField] Text distance;

    void Update()
    {
        float length = goalSign.position.x - runner.position.x;
        distance.text = "ゴールまで" + length.ToString("F2") + "m";
    }
}
