using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level02");
        }
    }
}
