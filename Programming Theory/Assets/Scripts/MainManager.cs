using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    [SerializeField] protected GameObject mainManager;
    public static MainManager Instance {get; private set;}

    private void Awake()
    {
        if(Instance != null){
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public virtual void ButtonClicked(){
        Debug.Log("Button was clicked");
    }

    public void ChangeScene(int sceneIndex){
        SceneManager.LoadScene(sceneIndex);
    }

    public void NextScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void PreviousScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    } 
}
