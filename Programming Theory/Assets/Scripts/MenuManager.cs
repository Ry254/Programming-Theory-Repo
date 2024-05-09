using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MainManager
{
    void Awake()
    {
        if(Instance == null){
            Instantiate(mainManager);
        }
    }

    public override void ButtonClicked(){
        Debug.Log("Button was clicked using MenuManager");
    }
}
