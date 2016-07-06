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

        // Add two numbers to using variables
        int n1 = 8;
        int n2 = 9;
        int answerForVariables = n1 + n2;
        Debug.Log(answerForVariables);

        // Shorten operations
        int answerForShortOperation;
        answerForShortOperation = 10;
        answerForShortOperation += 5;
        Debug.Log(answerForShortOperation);

        answerForShortOperation -= 5;
        Debug.Log(answerForShortOperation);

        answerForShortOperation *= 2;
        Debug.Log(answerForShortOperation);

        answerForShortOperation /= 10;
        Debug.Log(answerForShortOperation);

        // Show increment or decrement variables
        int answerForIncrement = 10;
        answerForIncrement++;
        Debug.Log(answerForIncrement);

        int answerForDecrement = 10;
        answerForDecrement--;
        Debug.Log(answerForDecrement);

        // Join two strings
        string str1 = "happy ";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        Debug.Log(message);

        // Shorten join operation of two strings
        string str1ForShortOperation = str1;
        string str2ForShortOperation = str2;
        str1ForShortOperation += str2ForShortOperation;
        Debug.Log(str1ForShortOperation);
    }

    void Update () {

    }
}
