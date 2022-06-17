using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : switchscene
{
    public Transform player;
    public float xPos;
    public float yPos;

    public string previous;

    public override void Start()
    {
        base.Start();

        if(prevScene == previous)
        {
            player.position = new Vector2(xPos, yPos);
        }
    }
}
