using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class GameManager : MainManager
{
    [SerializeField] GameObject cube;

    private int numberOfCubes_backingFeild;
    public int NumberOfCubes{
        get{return numberOfCubes_backingFeild;}
        set{
            if(value<0){
                Debug.LogError("numberOfCubes cannot be negative");
            }else{
                numberOfCubes_backingFeild = value;
            }
        }
    }

    void Awake()
    {
        if(Instance == null){
            Instantiate(mainManager);
        }
    }

    public void ButtonClicked(Slider slider){
        SetNumberOfCubes((int)slider.value);
        StartCoroutine(SpawnCube());
    }

    public void SetNumberOfCubes(int value){
        NumberOfCubes = value;
    }

    IEnumerator SpawnCube(){
        for(int x = 0; x < NumberOfCubes; x++){
            Instantiate(cube,new Vector3(0,10,0),cube.transform.rotation);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
