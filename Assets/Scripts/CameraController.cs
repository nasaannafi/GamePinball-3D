using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float returTime;
    public float followSpeed;
    public float Length;
    public Transform target;

    private Vector3 defaultPosition;
   

    public bool hasTarget { get { return target !=null; } }

    private void Start()
    {
        defaultPosition = transform.position;
        target = null;
    }

    private void Update()
    {
        if (hasTarget)
        {

            Vector3 targetToCameraDirection = transform.rotation * -Vector3.forward;
            Vector3 targetPosition = target.position + (targetToCameraDirection* Length);

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        }
    }

    public void FollowAtTarget(Transform targetTransform, float targetLength)
    {
        StopAllCoroutines();
        target = targetTransform;
        Length = targetLength;
    }

    public void GoBackToDefault()
    {
        target = null;

        // Gerakkan ke posisi default dalam waktu time
        StopAllCoroutines();
        StartCoroutine(MovePosition(defaultPosition, returTime));
    }

    private IEnumerator MovePosition(Vector3 target, float time)
    {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time)
        {
            // Pindahkan posisi kamera secara bertahap
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer / time));

            timer += Time.deltaTime;
            yield return null;
        }
        transform.position = target;
    }
}
