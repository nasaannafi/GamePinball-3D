using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text scoreText;


    public ScoreManagger scoreManagger;

    private void Update()
    {
        scoreText.text = scoreManagger.score.ToString();

    }
}
