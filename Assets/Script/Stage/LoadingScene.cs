using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Security.Permissions;

public class LoadingScene : MonoBehaviour
{
    public static string NextScene = "Stage1";
    float fTime = 0f;

    public GameObject stageT1;
    public GameObject stageT2;
    public GameObject stageT3;
    public GameObject title;


    void Update()
    {
        if (NextScene.Equals("Stage1"))
        {
            stageT1.SetActive(true);
            stageT2.SetActive(false);
            stageT3.SetActive(false);
            title.SetActive(false);
        }
        else if (NextScene.Equals("Stage2"))
        {
            stageT1.SetActive(false);
            stageT2.SetActive(true);
            stageT3.SetActive(false);
            title.SetActive(false);
        }
        else if (NextScene.Equals("Stage3"))
        {
            stageT1.SetActive(false);
            stageT2.SetActive(false);
            stageT3.SetActive(true);
            title.SetActive(false);
        }
        else
        {
            stageT1.SetActive(false);
            stageT2.SetActive(false);
            stageT3.SetActive(false);
            title.SetActive(true);

        }

        fTime += Time.deltaTime;


        if (fTime >= 2.5)
        {
            SceneManager.LoadScene(NextScene);
            NextScene = "Stage1";
        }
    }

}