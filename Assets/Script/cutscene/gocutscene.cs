using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gocutscene : MonoBehaviour
{
    public static bool isCutseneon;
    public Animator camAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isCutseneon = true;
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(stopCutscene), 3f);
            afterCut();
        }
    }

    void afterCut()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    void stopCutscene()
    {
        isCutseneon = false;
        camAnim.SetBool("cutscene1", false);
    }
}
