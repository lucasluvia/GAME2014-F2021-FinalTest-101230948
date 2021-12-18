// FloatingPlatform.cs
// Lucas Dunster 101230948
// DLM: 12/18/2021 - 1.0.4 (Audio)
// Manages animation state of floating platforms

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloatingPlatform : MonoBehaviour
{
    public bool hasCollidedWithPlayer = false;
    private Animator animator;

    private bool rechargePlayable = false;
    private bool shrinkPlayable = true;

    [SerializeField] AudioSource shrinkSound;
    [SerializeField] AudioSource rechargeSound;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("hasCollided", hasCollidedWithPlayer);
        if(rechargePlayable && !hasCollidedWithPlayer)
        {
            rechargeSound.Play();
            rechargePlayable = false;
            shrinkPlayable = true;
        }
    }

    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if(otherCollider.gameObject.CompareTag("Player"))
        {
            hasCollidedWithPlayer = true;
            if(shrinkPlayable)
            {
                shrinkSound.Play();
                shrinkPlayable = false;
            }
            rechargePlayable = true;
        }
    }

}
