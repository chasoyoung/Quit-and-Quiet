using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toStage1 : MonoBehaviour
{
    public void toStageClickListener()
    {
        Stage.targetList.Clear();
        Stage.targetList.Add("작은기린");
        Stage.targetList.Add("큰코끼리");
        Stage.targetList.Add("악어새");
        Stage.targetList.Add("파리");
        Stage.targetList.Add("풀1");
        Stage.targetList.Add("원숭이");
        Stage.targetList.Add("얼룩말무리");

        LoadingScene.NextScene = "Stage1";
        SceneManager.LoadScene("LoadingScene");
    }
}
