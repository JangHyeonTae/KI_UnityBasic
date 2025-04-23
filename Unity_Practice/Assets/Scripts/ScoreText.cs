using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    private void OnEnable()
    {
        TextUpdate(GameManager.Instance.Score);
        GameManager.Instance.OnScore += TextUpdate;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnScore -= TextUpdate;
    }
    void TextUpdate(int score)
    {
        scoreText.text = score.ToString();
    }
}
