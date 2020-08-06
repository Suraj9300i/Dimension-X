using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] int ScorePerBlock = 67;
    int TotalScore = 0;

    private void OnTriggerEnter(Collider other)
    {
        TotalScore += ScorePerBlock;
        text.text = TotalScore.ToString();
    }

    public int getTotalScore()
    {
        return TotalScore;
    }
}
