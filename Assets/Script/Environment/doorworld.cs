using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorworld : MonoBehaviour
{
    public GameObject target;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Interact();
        }
    }
    /*
    public void Interact()
    {
        GameMaster.transitionPlayer(target.transform.position);
    }
    */
}