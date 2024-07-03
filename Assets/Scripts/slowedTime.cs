using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;

public class slowedTime : MonoBehaviour
{
    public float slowDownFactor = 0.05f;
    public GameObject Object;
    public GameObject Player;
    private float distance;
    void Update()
    {

        distance = Vector3.Distance(Object.transform.position, Player.transform.position);

        float normalizedDistance = Mathf.Clamp01(distance / 50);

        float slowAreaWidth = 0.2f;

        Time.timeScale = Mathf.Lerp(0.2f, 1f, normalizedDistance);

        Time.fixedDeltaTime = Time.timeScale * 0.02f;

    }
}