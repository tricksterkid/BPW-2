using UnityEngine;

public class InteriorSwitch2 : MonoBehaviour
{
    public GameObject interior1;
    public GameObject interior2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            interior1.SetActive(true);
            interior2.SetActive(false);
            Debug.Log("Switched to interior 1");
        }
    }

}
