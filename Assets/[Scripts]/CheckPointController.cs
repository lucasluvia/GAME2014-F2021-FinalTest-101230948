// CheckPointController.cs
// Lucas Dunster 101230948
// DLM: Same From Template
// Controller for Checkpoints

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public Transform spawnPoint;
    public PlayerBehaviour player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.spawnPoint = spawnPoint;
        }
    }
}
