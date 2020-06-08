﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level03");
        }
    }
}
