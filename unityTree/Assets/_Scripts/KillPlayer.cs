﻿using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel(1);
            return;
        }

    }
}