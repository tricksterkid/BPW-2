using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
