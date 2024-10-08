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
    private int player1Score = 0;
    public int Player1Score 
    {
        get
        {
            return player1Score;
        }
        set
        {
            player1Score = value;
        }
    }
    private int player2Score = 0;
    public int Player2Score 
    {
        get
        {
            return player2Score;
        }
        set
        {
            player2Score = value;
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
        player2Score = 0;
        player1Score = 0;
        player = FindObjectOfType<Player>();
    }
}