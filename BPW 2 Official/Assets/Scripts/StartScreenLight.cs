using UnityEngine;

public class StartScreenLight : MonoBehaviour
{
    public GameObject standardLight;
    public GameObject specialLight;

    void OnMouseOver()
    {
        standardLight.SetActive(false);
        specialLight.SetActive(true);
    }

    void OnMouseExit()
    {
        specialLight.SetActive(false);
        standardLight.SetActive(true);
    }

}
