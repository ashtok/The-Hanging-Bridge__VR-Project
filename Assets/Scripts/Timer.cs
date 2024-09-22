using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float startTime;
    private float endTime;
    float elapsedTime  = 0.0f;

    /// <summary>
    /// Starts a simple Unity Timer
    /// </summary>
    public void StartTimer()
    {
        startTime = Time.time;
    }

    /// <summary>
    /// Stops the unity timer and returns the total elapsed time
    /// </summary>
    /// <returns></returns>
    public float StopTimer()
    {
        Debug.Log("Stopping Timer");
        if (elapsedTime == 0f)
        {
            endTime = Time.time;
            elapsedTime = endTime - startTime;
            Debug.Log($"Total Time Elapsed {elapsedTime}");
            return elapsedTime;
        }
        else
        {
            return elapsedTime;
        }
    }
}

