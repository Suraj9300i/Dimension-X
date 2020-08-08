using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class F : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        int s = PlayerPrefs.GetInt("TotalSCore");
        text.text = s.ToString();
    }
}
