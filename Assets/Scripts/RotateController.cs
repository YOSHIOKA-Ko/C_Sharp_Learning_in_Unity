using UnityEngine;
using System.Collections;

public class RotateController : MonoBehaviour {

    float rotateSpeed = 0;

    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            this.rotateSpeed = 10;
        }

        transform.Rotate(0, this.rotateSpeed, 0);

        this.rotateSpeed *= .96f;
    }
}
