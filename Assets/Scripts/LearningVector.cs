using UnityEngine;
using System.Collections;

public class LearningVector : MonoBehaviour
{

    void Start()
    {
        Vector2 playerPosition = new Vector2(3.0f, 4.0f);
        playerPosition.x += 8.0f;
        playerPosition.y += 5.0f;
        Debug.Log(playerPosition);

        Vector2 startPosition = new Vector2(2.0f, 1.0f);
        Vector2 endPosition = new Vector2(8.0f, 5.0f);
        Vector2 direction = endPosition - startPosition;
        Debug.Log(direction);

        float length = direction.magnitude;
        Debug.Log(length);
    }
}
