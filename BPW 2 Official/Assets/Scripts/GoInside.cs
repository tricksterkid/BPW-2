﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GoInside : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
