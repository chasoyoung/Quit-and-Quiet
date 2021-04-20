using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toStage3 : MonoBehaviour
{
    public void toStageClickListener()
    {
        Stage.targetList.Clear();
        Stage.targetList.Add("바이올린2");
        Stage.targetList.Add("첼로1");
        Stage.targetList.Add("사진");
        Stage.targetList.Add("튜바1");
        Stage.targetList.Add("심벌즈");
        Stage.targetList.Add("소프라노3");
        Stage.targetList.Add("알토2");
        Stage.targetList.Add("테너1");
        Stage.targetList.Add("코고는관객");
        Stage.targetList.Add("무대바리톤");

        LoadingScene.NextScene = "Stage3";
        SceneManager.LoadScene("LoadingScene");
    }
}
