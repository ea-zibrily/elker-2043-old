using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition1 : MonoBehaviour
{
    [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);

        //ALPHA
        LeanTween.alpha(fader, 1, 0.5f);
        LeanTween.alpha (fader, 0, 1.5f).setOnComplete (() => 
        {
            fader.gameObject.SetActive (false);
        });
    }
    
    public void OpenMenuScene()
    {
        fader.gameObject.SetActive(true);

        // ALPHA
        LeanTween.alpha(fader, 0, 0.5f); 
        LeanTween.alpha (fader, 1, 1.5f).setOnComplete (() => {
         SceneManager.LoadScene (0);
         });

    }

    public void openVid()
    {
        fader.gameObject.SetActive(true);
        // ALPHA
        LeanTween.alpha (fader, 0, 0.5f);
        LeanTween.alpha (fader, 1, 1.5f).setOnComplete (() => 
        {
            //Example for little pause before laoding the next scene
            SceneManager.LoadScene(1);
        });

    }
}