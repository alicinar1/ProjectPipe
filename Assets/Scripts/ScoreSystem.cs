using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        SetScoreText();        
    }

    private void SetScoreText()
    {
        scoreText.text = "SCORE: " + GameManager.Instance.CalculateScore().ToString();
    }  


}
