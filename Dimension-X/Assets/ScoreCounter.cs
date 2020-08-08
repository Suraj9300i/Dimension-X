using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int ScorePerBlock = 1;
    [SerializeField] int TotalScore = 0;


    private void OnTriggerEnter(Collider other)
    {
        TotalScore += ScorePerBlock;
    }

    public int getTotalScore()
    {
        return TotalScore;
    }
}
