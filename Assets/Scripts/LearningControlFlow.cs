using UnityEngine;
using System.Collections;

public class LearningControlFlow : MonoBehaviour {

    void Start () {
        // Conditional of if only
        int herbNum = 1;
        if (herbNum == 1) {
            Debug.Log("Repairs 50");
        }

        // Conditional of if and else
        int stamina = 200;
        if (stamina >= 100) {
            Debug.Log("Attack!");
        } else {
            Debug.Log("Defense!");
        }
    }
}
