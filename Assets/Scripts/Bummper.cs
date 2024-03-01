using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bummper : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManagger scoreManagger;


    private Renderer render;
    private Animator animator;

    private void Start()
    {
        render = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        render.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // Animasi
            animator.SetTrigger("hit");

            // PlaySFX
            audioManager.PlaySFX(collision.transform.position);

            // PlayVFX
            vfxManager.PlayVFX(collision.transform.position);

            // score add
            scoreManagger.AddScore(score);
            
        }
    }
}