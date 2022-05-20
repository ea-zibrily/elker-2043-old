using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleTeleport : MonoBehaviour
{
    public GameObject currentLift;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position = currentLift.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D go)
    {
        if (go.CompareTag("teleporter"))
        {
            currentLift = go.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D go)
    {
        if (go.CompareTag("teleporter"))
        {
            if (go.gameObject == currentLift)
            {
                currentLift = null;
            }         
        }
    }
}
