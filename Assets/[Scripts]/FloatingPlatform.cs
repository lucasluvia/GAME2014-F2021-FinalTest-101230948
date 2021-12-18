// FloatingPlatform.cs
// Lucas Dunster 101230948
// DLM: 12/18/2021
// Manages animation state of floating platforms

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloatingPlatform : MonoBehaviour
{
    public bool hasCollidedWithPlayer = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("hasCollided", hasCollidedWithPlayer);
    }

    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if(otherCollider.gameObject.CompareTag("Player"))
        {
            hasCollidedWithPlayer = true;
        }
    }

}
