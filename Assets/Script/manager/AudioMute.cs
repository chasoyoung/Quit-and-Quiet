using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMute : MonoBehaviour
{
    AudioSource audio;
    public GameObject TargetListUI;
    public GameObject StageClearUI;
    public GameObject StageExitUI;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        if(TargetListUI.active == true || StageClearUI.active == true || StageExitUI.active == true)
        {
            audio.mute = true;
        }
        else
        {
            audio.mute = false;
        }
    }
}
