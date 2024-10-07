using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{  
    [SerializeField] private int score = 10;
    void OnTriggerEnter(Collider collider) {
        Destroy(gameObject);
        ScoreKeeper.Instance.Score += score;
    }
}
