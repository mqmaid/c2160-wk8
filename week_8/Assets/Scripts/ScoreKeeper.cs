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
                Debug.LogError("There is no ScoreKeeper instance in the scene.");
            }
            return instance;
        }
    }
    private Player player;
    private int score = 0;
    public int Score 
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
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
    void Start()
    {
        score = 0;
        player = FindObjectOfType<Player>();
    }
}