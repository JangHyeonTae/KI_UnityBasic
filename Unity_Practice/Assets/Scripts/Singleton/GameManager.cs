using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get 
        { 
            if (instance == null)
            {
                GameObject gameObject = new GameObject("GameManager");
                instance = gameObject.AddComponent<GameManager>();
            }
            return instance; 
        }
    }

    public event Action<int> OnScore;

    private int score = 0;
    public int Score { get {  return score; } set { score = value; OnScore?.Invoke(score); } }
    public int maxScore = 5;
    private void Awake()
    {
        CreateManager();
    }

    public void CreateManager()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
