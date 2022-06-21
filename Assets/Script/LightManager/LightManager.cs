using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public GameObject liftLight;
    void IdleLift()
    {
        liftLight.SetActive(false);
    }
    void OpenCloseLift()
    {
        liftLight.SetActive(true);
    }
}
