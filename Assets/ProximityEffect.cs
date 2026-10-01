using UnityEngine;

public class ProximityEffect : MonoBehaviour
{

    private void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the zone is the Player
        if (other.CompareTag("Player"))
        {
            Invoke("SetSpotlightVisible", 0.25f);
            Invoke("SetTitleVisible", 1f);
            Invoke("SetDescriptionVisible", 3f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object leaving the zone is the Player
        if (other.CompareTag("Player"))
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
        }
    }

    void SetTitleVisible()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    void SetDescriptionVisible()
    {
        transform.GetChild(1).gameObject.SetActive(true);
    }

    void SetSpotlightVisible()
    {
        transform.GetChild(2).gameObject.SetActive(true);
    }
}


