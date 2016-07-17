using UnityEngine;
using System.Collections;

public class RunningSpeedController : MonoBehaviour {

    float runningSpeed = 0;

    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            this.runningSpeed = .1f;
        }

        transform.Translate(this.runningSpeed, 0, 0);

        if(this.runningSpeed <= .01) {
            this.runningSpeed = 0;
        } else {
            this.runningSpeed *= .98f;
        }
    }
}
