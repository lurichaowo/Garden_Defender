﻿using UnityEngine;
using System.Collections;

public class spawn_direction : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Vector3 euler = transform.eulerAngles;
        euler.y = Random.Range(0f, 360f);
        transform.eulerAngles = euler;
    }


}
