using UnityEngine;
using System.Collections;

public class LearningMethods : MonoBehaviour {

    void SayHello() {
        Debug.Log("Hello");
    }

    void CallName(string name) {
        Debug.Log("Hello" + name);
    }

    int Add(int a, int b){
        int c = a + b;
        return c;
    }

    void Start () {
        SayHello();
        CallName("Tracer");

        // Using the Add method, find the answer
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
    }
}
