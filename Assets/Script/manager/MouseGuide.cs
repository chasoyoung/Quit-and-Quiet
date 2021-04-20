using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGuide : MonoBehaviour
{
    public GameObject followingCube;
    private float initialZPos = 0f;

    void Update()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        followingCube.transform.position = new Vector3(newPosition.x, newPosition.y, 0);
    }

}
