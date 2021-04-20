using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toSelect : MonoBehaviour
{
    public void toSelectClickListener()
    {
        LoadingScene.NextScene = "StageSelect";

        SceneManager.LoadScene("LoadingScene");
    }

}
