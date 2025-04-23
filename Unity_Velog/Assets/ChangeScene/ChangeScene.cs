using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeNextScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("SceneLevel1", LoadSceneMode.Additive);
        operation.allowSceneActivation = true;             //씬 로딩 완료시 바로 씬 전환을 하는지 여부
        bool isLoaded = operation.isDone;                  //씬 로딩의 완료여부 확인
        float progress = operation.progress;               //씬 로딩의 진행률 확인 0~1사이의 값으로 진행
        operation.completed += (oper) => { };              //씬 로딩의 완료시 진행할 이벤트 추가
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.UnloadSceneAsync(1);
        }
    }
}
