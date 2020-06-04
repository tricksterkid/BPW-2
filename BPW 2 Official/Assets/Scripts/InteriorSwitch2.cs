using UnityEngine;

public class InteriorSwitch2 : MonoBehaviour
{
    bool TriggerSwitch = false;

    public GameObject interior1;
    public GameObject interior2;
    public GameObject popup;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TriggerSwitch = true;
            popup.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        TriggerSwitch = false;
        popup.SetActive(false);
    }

    void Update()
    {
        if (TriggerSwitch == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                interior2.SetActive(false);
                interior1.SetActive(true);
            }
        }
    }
}
