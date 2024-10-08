using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{  
    [SerializeField] private int score = 10;
<<<<<<< Updated upstream
    void OnTriggerEnter(Collider collider) {
        Destroy(gameObject);
        ScoreKeeper.Instance.Score += score;
=======
    void OnTriggerEnter(Collider collider)
    {
        string tag = collider.tag;
        switch (tag) {
            case "Player1":
                Destroy(gameObject);
                ScoreKeeper.Instance.Player1Score += score;
                break;
            case "Player2":
                Destroy(gameObject);
                ScoreKeeper.Instance.Player2Score += score;
                break;
        }
>>>>>>> Stashed changes
    }
}
