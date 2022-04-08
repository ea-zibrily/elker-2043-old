using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
    public float  fs;
    public Transform target;
    public float yOffset;
    public float xOffset;

    void Update() {
        Vector3 newPos = new Vector3(target.position.x + xOffset, target.position.y + yOffset, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, newPos, fs*Time.deltaTime);
    }
}
