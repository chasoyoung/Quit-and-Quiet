using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toStage2 : MonoBehaviour
{
    public void toStageClickListener()
    {
        Stage.targetList.Clear();
        Stage.targetList.Add("상어");
        Stage.targetList.Add("고등어");
        Stage.targetList.Add("새우");
        Stage.targetList.Add("말미잘흰동가리");
        Stage.targetList.Add("거거");
        Stage.targetList.Add("고둥");
        Stage.targetList.Add("물개");
        Stage.targetList.Add("돌고래");
        Stage.targetList.Add("잠수함");

        LoadingScene.NextScene = "Stage2";
        SceneManager.LoadScene("LoadingScene");
    }
}
