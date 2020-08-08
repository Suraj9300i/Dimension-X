using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textM;
    ScoreCounter scoreKeeper;

    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreCounter>();
    }

    private void Update()
    {
        
        textM.text = scoreKeeper.getTotalScore().ToString();
    }
}
