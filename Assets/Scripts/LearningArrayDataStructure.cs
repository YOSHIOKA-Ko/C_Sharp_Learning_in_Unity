using UnityEngine;
using System.Collections;

public class LearningArrayDataStructure : MonoBehaviour
{

    void Start()
    {
        // Show five element using array
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        Debug.Log("Fix for loop");

        // Shorten structure of array
        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
        }
        Debug.Log("Fix for loop");

        // Calculate averages using length of array
        int sum = 0;

        for (int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        int average = sum / points.Length;
        Debug.Log(average);
    }
}
