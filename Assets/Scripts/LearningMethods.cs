using UnityEngine;
using System.Collections;

public class LearningMethods : MonoBehaviour {

    void SayHello() {
        Debug.Log("Hello");
    }

    void CallName(string name) {
        Debug.Log("Hello" + name);
    }

    void Start () {
        SayHello();
        CallName("Tracer");
    }
}
