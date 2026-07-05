using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pressEUI;
    private bool playerNear = false;

    void Start()
    {
        pressEUI.SetActive(false);
    }

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            PlayerInventory.hasKey = true;

            pressEUI.SetActive(false);

            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            pressEUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            pressEUI.SetActive(false);
        }
    }
}