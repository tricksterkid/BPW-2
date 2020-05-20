using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level02");
            Debug.Log("You went outside");
        }
    }
}
