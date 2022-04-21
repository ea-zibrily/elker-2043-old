using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleCamera : MonoBehaviour
{
    [SerializeField] public float camSpeed;
    [SerializeField] public Transform ele;
    [SerializeField] public Vector3 offset;

    void Update() 
    {
        transform.position = Vector3.Lerp(transform.position, ele.position + offset, camSpeed * Time.deltaTime);
    }
}

/*
    [SerializeField] private Transform ele;
    private float smoothCam = 0.25f;
    private Vector3 offset = new Vector3(0f, 5f, -10f);
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        Vector3 elePosititon =  ele.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, elePosititon, ref velocity, smoothCam);
    }
    */
