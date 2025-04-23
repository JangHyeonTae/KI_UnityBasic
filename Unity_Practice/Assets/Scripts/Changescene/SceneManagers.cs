using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        
            SceneManager.LoadSceneAsync("Practice2", LoadSceneMode.Additive);
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Player") return;
        
            SceneManager.UnloadSceneAsync("Practice2");
        
    }


   // public void ChangeNextScene()
   // {
   //     AsyncOperation operation = SceneManager.LoadSceneAsync("Practice2", LoadSceneMode.Additive);
   //
   //     operation.allowSceneActivation = true;
   //     bool isLoaded = operation.isDone;
   //     float progress = operation.progress;
   //     operation.completed += (oper) => { };
   //
   // }

    

}
    

