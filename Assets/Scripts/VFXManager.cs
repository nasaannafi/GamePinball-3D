using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudiosource;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudiosource, spawnPosition, Quaternion.identity);
    }
}