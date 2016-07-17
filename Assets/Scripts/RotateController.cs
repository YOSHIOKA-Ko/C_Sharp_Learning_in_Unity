using UnityEngine;
using System.Collections;

public class RotateController : MonoBehaviour {

    float rotateSpeed = 0;
    float stopSpeed = .1f;

    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            this.rotateSpeed = 10;
        }

        transform.Rotate(0, this.rotateSpeed, 0);

        if(this.rotateSpeed <= this.stopSpeed) {
            this.rotateSpeed = 0;
        } else {
            this.rotateSpeed *= .96f;
        }
    }
}
