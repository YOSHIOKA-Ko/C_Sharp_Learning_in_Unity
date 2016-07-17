using UnityEngine;
using System.Collections;

public class RunningSpeedController : MonoBehaviour {

    float runningSpeed = 0;

    void Update () {
        transform.Translate(this.runningSpeed, 0, 0);

        if(this.runningSpeed <= .01) {
            this.runningSpeed = 0;
        } else {
            this.runningSpeed *= .98f;
        }
    }
}
