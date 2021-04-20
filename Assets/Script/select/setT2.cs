using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setT2 : MonoBehaviour
{
    public GameObject stageT1;
    public GameObject stageT2;
    public GameObject stageT3;

    public void setT()
    {
        LoadingScene.NextScene = "Stage2";

        stageT1.SetActive(false);
        stageT2.SetActive(true);
        stageT3.SetActive(false);
    }
}
