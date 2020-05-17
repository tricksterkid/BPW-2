using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHome : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
