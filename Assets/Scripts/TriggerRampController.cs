using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreManagger scoreManagger;


    public void AddScore(Collider other)
    {
        if (other == bola)
        {
            //score add
            scoreManagger.AddScore(score);
        }
    }
}
