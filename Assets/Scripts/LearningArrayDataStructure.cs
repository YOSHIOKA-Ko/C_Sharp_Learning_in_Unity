﻿using UnityEngine;
using System.Collections;

public class LearningArrayDataStructure : MonoBehaviour {

    void Start () {
        // Show five element using array
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++) {
            Debug.Log(array[i]);
        }
    }
}
