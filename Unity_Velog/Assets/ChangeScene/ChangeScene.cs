using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeNextScene()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("SceneLevel1", LoadSceneMode.Additive);
        operation.allowSceneActivation = true;             //�� �ε� �Ϸ�� �ٷ� �� ��ȯ�� �ϴ��� ����
        bool isLoaded = operation.isDone;                  //�� �ε��� �ϷῩ�� Ȯ��
        float progress = operation.progress;               //�� �ε��� ����� Ȯ�� 0~1������ ������ ����
        operation.completed += (oper) => { };              //�� �ε��� �Ϸ�� ������ �̺�Ʈ �߰�
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
