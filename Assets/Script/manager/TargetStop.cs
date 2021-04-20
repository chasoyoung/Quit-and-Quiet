using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TargetStop : MonoBehaviour
{
    public GameObject audio;
    public GameObject TargetObject;


    void AudioStop()
    {
        audio.SetActive(false);   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Stage.CastRay();

            if (TargetObject.name.Equals(Stage.target))
            {
                AudioStop();
                
            }
        }
        
    }

}
