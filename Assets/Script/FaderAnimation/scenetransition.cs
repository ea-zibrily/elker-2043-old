using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition : MonoBehaviour
{
    [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);

        /*
        // ALPHA
        LeanTween.alpha (fader, 1, 0);
        LeanTween.alpha (fader, 0, 0.5f).setOnComplete (() => 
        {
            fader.gameObject.SetActive (false);
        });
        */

        
        // SCALE
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f);
        LeanTween.scale(fader, Vector3.zero, 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            fader.gameObject.SetActive(false);
        });

    }
    
    public void OpenMenuScene()
    {
        fader.gameObject.SetActive(true);

        // ALPHA
        // LeanTween.alpha (fader, 0, 0);
        // LeanTween.alpha (fader, 1, 0.5f).setOnComplete (() => {
        //     SceneManager.LoadScene (0);
        // });

        // SCALE
        LeanTween.scale(fader, Vector3.zero, 0.5f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            SceneManager.LoadScene(0);
        });
    }
    

    public void OpenLvl2Scene()
    {
        fader.gameObject.SetActive(true);

        /*
        // ALPHA
        LeanTween.alpha (fader, 0, 0);
        LeanTween.alpha (fader, 1, 0.5f).setOnComplete (() => 
        {
            //Example for little pause before laoding the next scene
            SceneManager.LoadScene(1);
        });
        */

        
        // SCALE
        LeanTween.scale(fader, Vector3.zero, 0.5f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            // Example for little pause before laoding the next scene
            SceneManager.LoadScene(1);
        });
        
    }


    public void OpenAdmin1Scene()
    {
        fader.gameObject.SetActive(true);

        /*
        // ALPHA
        LeanTween.alpha (fader, 0, 0.5f);
        LeanTween.alpha (fader, 1, 1.5f).setOnComplete (() => 
        {
        // Example for little pause before laoding the next scene
        Invoke ("Admin1", 0.5f);
         });
        */

        
        // SCALE
        LeanTween.scale(fader, Vector3.zero, 0.5f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() => {
            // Example for little pause before laoding the next scene
            Invoke("Admin1", 0.5f);
        });

    }

    private void Admin1()
    {
        SceneManager.LoadScene(2);
    }
}
    /*
    [SerializeField] RectTransform fader;

    private void Start()
    {
        fader.gameObject.SetActive(true);

        LeanTween.scale(fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setOnComplete(() =>
        {
            fader.gameObject.SetActive(false);
        });
    }
    
    public void openmenuScene()
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        });
        

    }
    

    public void ingameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);

    }
    */
