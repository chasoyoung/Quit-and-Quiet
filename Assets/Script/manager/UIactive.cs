using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIactive : MonoBehaviour
{
    public GameObject activeUI;

    public void UISetActive()
    {
        activeUI.SetActive(!activeUI.active);
    }

}
