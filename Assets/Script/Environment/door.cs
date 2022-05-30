using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public float closeDoorDelay;
    Animator myAnim;
    void Awake()
    {
        myAnim = GetComponent<Animator>();
    }

    void DisableCollider2D()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    void EnableCollider2D()
    {
        GetComponent<Collider2D>().enabled = true;
    }

    public void Open()
    {
        myAnim.SetTrigger("dooropen");
    }

    public void Close()
    {
       StartCoroutine(CloseNow ());
    }

    private IEnumerator CloseNow()
    {
        yield return new WaitForSeconds(closeDoorDelay);
        myAnim.SetTrigger("doorclose");
    }

    
}
