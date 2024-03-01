using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode input;

    public float targetPressed;
    public float targetRelease;
    private HingeJoint hinge;
 
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }


    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
            JointSpring jointSpring = hinge.spring;

            if(Input.GetKey(input))
            {
                jointSpring.targetPosition = targetPressed;
            }

            else
            {
                jointSpring.targetPosition = targetRelease;
            }
            hinge.spring = jointSpring;
    }

}
