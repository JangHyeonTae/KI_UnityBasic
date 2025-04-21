using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    private bool isLoad = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            isLoad = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(1);
            isLoad = false;
        }
        else if (GameManager.Instance.score >= GameManager.Instance.maxScore && !isLoad)
        {
            isLoad = true;
            SceneManager.LoadScene(2);
        }
    }

}
