using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class HintButtonBlock : MonoBehaviour
{
    public GameObject Btn;
    private Button btn;
    string bname;

    void Start()
    {
        bname = Btn.name;
        btn = GetComponent<Button>();

    }

    void Update()
    {
        if (Stage.targetList.Contains(bname) == true)
        {
            btn.interactable = true;
        }
        if (Stage.targetList.Contains(bname) == false)
        {
            btn.interactable = false;
        }
        
    }
}
