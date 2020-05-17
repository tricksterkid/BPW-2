using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public void Begin()
    {
        SceneManager.LoadScene("Level01");
    }
}
