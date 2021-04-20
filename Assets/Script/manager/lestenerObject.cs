using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class lestenerObject : MonoBehaviour
{
    public GameObject StageClearUI;
    public GameObject StageExitUI;

    public GameObject followingCube;
    private float initialZPos = 0f;

    public Sprite[] type = new Sprite[2];
    public SpriteRenderer typeimage;

    void Start()
    {
        typeimage = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(StageClearUI.active || StageExitUI.active == true)
        {
            followingCube.GetComponent<Renderer>().enabled = false;
        }
        else 
        {
            followingCube.GetComponent<Renderer>().enabled = true;
        }
        if(followingCube.GetComponent<Renderer>().enabled == true)
        {
            mousemove();
        }
    }
    void mousemove()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        followingCube.transform.position = new Vector3(newPosition.x, newPosition.y, 0);

        OnMouseOver();
    }
    void OnMouseOver()
    {

        Stage.CastRay();
        if (Stage.targetList.Contains(Stage.target) == true)
        {
            typeimage.sprite = type[1];
        }
        else
        {
            typeimage.sprite = type[0];
        }
    }

}
