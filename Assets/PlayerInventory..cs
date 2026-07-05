using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    public GameObject pressQUI;
    public Animator doorAnimator;

    bool playerNear = false;

    void Start()
    {
        pressQUI.SetActive(false);
    }

    void Update()
    {
        if(playerNear && PlayerInventory.hasKey && Input.GetKeyDown(KeyCode.Q))
        {
            doorAnimator.SetTrigger("Open");

            pressQUI.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = true;

            if(PlayerInventory.hasKey)
                pressQUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = false;
            pressQUI.SetActive(false);
        }
    }
}