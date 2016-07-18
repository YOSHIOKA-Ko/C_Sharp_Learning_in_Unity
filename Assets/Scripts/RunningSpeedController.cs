using UnityEngine;
using System.Collections;

public class RunningSpeedController : MonoBehaviour {

    float runningSpeed = 0;
    Vector3 swipeStartPositions;

    void Update () {
        transform.Translate(this.runningSpeed, 0, 0);

        if(Input.GetMouseButtonDown(0)) {
            this.swipeStartPositions = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0)) {
            Vector2 swipeEndPositions = Input.mousePosition;
            float swipeLength = (swipeEndPositions.x - this.swipeStartPositions.x);

            this.runningSpeed = swipeLength / 500;
        }

        if(this.runningSpeed <= .01) {
            this.runningSpeed = 0;
        } else {
            this.runningSpeed *= .98f;
        }
    }
}
