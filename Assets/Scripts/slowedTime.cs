using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;

public class slowedTime : MonoBehaviour
{
    public float slowDownFactor = 0.05f;
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.T))
        {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;

        }

    }
}