using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;

    private void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spwanPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spwanPosition, Quaternion.identity);
    }
}
