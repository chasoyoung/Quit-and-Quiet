using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setT1 : MonoBehaviour
{
    public GameObject stageT1;
    public GameObject stageT2;
    public GameObject stageT3;

    public void setT()
    {
        LoadingScene.NextScene = "Stage1";

        stageT1.SetActive(true);
        stageT2.SetActive(false);
        stageT3.SetActive(false);
    }
}
