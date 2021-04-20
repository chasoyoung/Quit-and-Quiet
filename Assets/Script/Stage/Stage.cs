using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    public static string target;
    public GameObject StageClearUI;

    private Text targetCount;
    public static List<string> targetList = new List<string>();

    public AudioSource effect;

    void Start()
    {
        targetCount = GameObject.Find("count").GetComponent<Text>();
        AudioSource effect = GetComponent<AudioSource>();
    }

    void Update()
    {
        SetCountText();

        if (targetList.Count == 0)
        {
            StageClearUI.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            CastRay();

            if (targetList.Contains(target) == true)
            { 
                targetList.Remove(target);
                effect.Play();
            }
        }
    }


    public static void CastRay()
    {

        target = null;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

        if (hit.collider != null)
        {
            target = hit.collider.name;

        }
    }

    void SetCountText()
    {
        targetCount.text = Stage.targetList.Count.ToString();
    }

}