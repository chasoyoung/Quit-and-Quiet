using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideButton : MonoBehaviour
{
    public GameObject GuideUI;

    public void GuideSetActive()
    {
        GuideUI.SetActive(true);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GuideUI.SetActive(false);
        }

    }
    
}
