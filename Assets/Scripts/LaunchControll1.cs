using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchControl : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private bool isHold = false;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput();
        }
    }

    private void ReadInput()
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold());
        }
    }

    private IEnumerator StartHold()
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input) && timeHold < maxTimeHold)
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);
            yield return null;
            timeHold += Time.deltaTime;
        }

        bola.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}