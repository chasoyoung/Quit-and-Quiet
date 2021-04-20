using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setT3 : MonoBehaviour
{
    public GameObject stageT1;
    public GameObject stageT2;
    public GameObject stageT3;

    public void setT()
    {
        LoadingScene.NextScene = "Stage3";

        stageT1.SetActive(false);
        stageT2.SetActive(false);
        stageT3.SetActive(true);
    }
}
