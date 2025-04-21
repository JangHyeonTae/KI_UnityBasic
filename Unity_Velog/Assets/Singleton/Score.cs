using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text numText;

    private void Awake()
    {
        numText.text = GameManager.Instance.score.ToString();
    }
    
    public void Press1()
    {
        GameManager.Instance.score = int.Parse(numText.text) + 1;
        numText.text = GameManager.Instance.score.ToString();
    }

}
