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
    }

    void Update () {

    }
}
