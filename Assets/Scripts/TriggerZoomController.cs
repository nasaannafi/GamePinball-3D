using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float Length;

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            cameraController.FollowAtTarget(bola.transform, Length);
        }
    }

}
