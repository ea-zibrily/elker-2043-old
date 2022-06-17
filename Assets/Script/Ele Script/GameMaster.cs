using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    //DoorPortal
    public Vector2 lastCheckPointPos;

    //DoorWorld
    public Image fader;
    private GameObject player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
   /*
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public static void transitionPlayer(Vector3 pos)
    {
        instance.StartCoroutine(instance.Transition(pos));
    }

    private IEnumerator Transition(Vector3 pos)
    {
        float i;
        fader.gameObject.SetActive(true);

        for (i = 0; i < 1; i += Time.deltaTime / 0.25f)
        {
            fader.color = new Color(0, 0, 0, Mathf.Lerp(0, 1, i));
            yield return null;
        }

        player.transform.position = pos;
        yield return new WaitForSeconds(1);

        for (i = 0; i < 1; i += Time.deltaTime / 0.25f)
        {
            fader.color = new Color(0, 0, 0, Mathf.Lerp(1, 0, i));
            yield return null;
        }

        fader.gameObject.SetActive(false);
    }
   */
    
}
