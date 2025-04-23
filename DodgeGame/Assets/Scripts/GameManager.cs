using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UnityEvent OnDied;

    public bool isGameOver;
    public GameObject player;
    [SerializeField] Transform spawnPosition;

    [Header("UI")]
    [SerializeField] private GameObject gameStartPanel;
    [SerializeField] private Button startBtn;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Button retryBtn;

    void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Init()
    {
        isGameOver = true;
        player.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    private void OnEnable()
    {
        Init();
        OnDied.AddListener(GameOver);
        startBtn.onClick.AddListener(GameStart);
        retryBtn.onClick.AddListener(GameStart);
    }

    private void OnDisable()
    {
        OnDied.RemoveListener(GameOver);
        startBtn.onClick.RemoveListener(GameStart);
        retryBtn.onClick.RemoveListener(GameStart);
    }


    private void GameOver()
    {
        isGameOver = true;
        player.SetActive(false);
        gameOverPanel.SetActive(true);
    }
    private void GameStart()
    {
        isGameOver = false;
        player.transform.position = spawnPosition.position;
        player.SetActive(true);
        gameStartPanel.SetActive(false);
        gameOverPanel.SetActive(false);

    }
}
