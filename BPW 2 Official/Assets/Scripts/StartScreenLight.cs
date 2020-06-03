using UnityEngine;

public class StartScreenLight : MonoBehaviour
{
    public GameObject standardLight;
    public GameObject specialLight;

    void OnMouseOver()
    {
        standardLight.SetActive(false);
        specialLight.SetActive(true);

        Debug.Log("Changed lighting to special");
    }

    void OnMouseExit()
    {
        standardLight.SetActive(true);
        specialLight.SetActive(false);
        Debug.Log("Changed lighting to normal");
    }

}
