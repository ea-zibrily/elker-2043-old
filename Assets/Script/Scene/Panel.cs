using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    public GameObject panel;
   
   public void closePanel()
   {
       panel.SetActive(false);
   }

}
