using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagger : MonoBehaviour
{
    public float score;

    public void AddScore(float addition)
    {
        score += addition;
    }

    public void ResetScore()
    {
        score = 0;
    }

}
