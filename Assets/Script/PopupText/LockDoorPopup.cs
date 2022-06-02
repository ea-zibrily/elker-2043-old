using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorPopup : MonoBehaviour
{
    public GameObject lockpopup;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        lockpopup.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        lockpopup.SetActive(false);
    }
}
