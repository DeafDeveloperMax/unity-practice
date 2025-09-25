using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3((float)17.35, (float)2.77, (float)1.28);
    
    void Start()
    {

    }
    
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}