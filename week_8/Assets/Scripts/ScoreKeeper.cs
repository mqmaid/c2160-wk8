using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;
    static public ScoreKeeper Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no GameManager instance in the scene.");
            }
            return instance;
        }
    }
    //private Player player;
    private int score = 0;
    public int Score 
    {
        get
        {
            return score;
        }
    }
    [SerializeField] private int scorePoint = 10;
    void Awake()
    {
        if (instance != null) 
        {
            Destroy(gameObject);            
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }        
    }
    public void Start()
    {
        score = 0;
      //  player = FindObjectOfType<Player>();
    }

    public void GainScore()
    {
        score += scorePoint;
    }
}