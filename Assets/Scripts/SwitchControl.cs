using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    public ScoreManagger scoreManagger;

    private SwitchState state;
    private Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        { 
            state = SwitchState.On;
            render.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            render.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }

        //Add score
        scoreManagger.AddScore(score);

    }


    private IEnumerator Blink(int times)
    {

        state = SwitchState.Blink;

        int blinkTimes = times * 2;
        for (int i = 0 ; i< times; i++)
        {
            render.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            render.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));

    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}