using UnityEngine;
using System.Collections;

public class LearningVector : MonoBehaviour {

    void Start () {
        Vector2 playerPosition = new Vector2(3.0f, 4.0f);
        playerPosition.x += 8.0f;
        playerPosition.y += 5.0f;
        Debug.Log(playerPosition);
    }
}
