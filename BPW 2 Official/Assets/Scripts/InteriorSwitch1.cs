using UnityEngine;

public class InteriorSwitch1 : MonoBehaviour
{
    public GameObject interior1;
    public GameObject interior2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            interior1.SetActive(false);
            interior2.SetActive(true);
            Debug.Log("Switched to interior 2");
        }
    }

}
