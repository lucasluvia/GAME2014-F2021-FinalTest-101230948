﻿// MiniMapFollow.cs
// Lucas Dunster 101230948
// DLM: Same From Template
// Makes the MiniMap follow the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0.0f, 0.0f, -10f);
    }
}
