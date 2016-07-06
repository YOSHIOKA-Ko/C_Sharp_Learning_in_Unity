using UnityEngine;
using System.Collections;

public class LearningVariables : MonoBehaviour {

    void Start () {
        // Show "Hello World" to console view
        Debug.Log("Hello World");

        // Show vavible in age to console view
        int age;
        age = 30;
        Debug.Log(age);

        // Assign height1 into height2, and Show height2 to console view
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        // Show a in string to console view
        string userName;
        userName = "YOSHIOKA Ko57";
        Debug.Log(userName);

        // Do four arithmetic operations, and show to Console view
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);
    }

    void Update () {

    }
}
