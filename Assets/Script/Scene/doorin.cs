using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorin : MonoBehaviour
{
    [Header("Door Setting")]
    private bool playerDetected;
    public Transform doorPos;
    public float width;
    public float height;
    public LayerMask whatIsPlayer;

    [Header("Switch Scene")]
    switchscene switchh;
    public string sceneName;

    private void Start()
    {
        switchh = FindObjectOfType<switchscene>();
    }

    void Update()
    {
        playerDetected = Physics2D.OverlapBox(doorPos.position, new Vector2(width, height), 0, whatIsPlayer);
    
        if(playerDetected)
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                switchh.SwitchScene(sceneName);
            }
        }
    
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(doorPos.position, new Vector3(width, height, 1));
    }
}
