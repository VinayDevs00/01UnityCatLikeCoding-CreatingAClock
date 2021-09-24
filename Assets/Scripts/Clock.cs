using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Clock : MonoBehaviour
{

    [SerializeField]
    public Transform hourLine, minuteLine, secondLine;

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    // Update is called once per frame
    void Update()
    {
        var time = DateTime.Now;
		hourLine.localRotation =
			Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
		minuteLine.localRotation =
			Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
		secondLine.localRotation =
			Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}
