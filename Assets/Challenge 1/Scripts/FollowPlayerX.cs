using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3 (17.35f, 2.77f, 1.28f);
    
    void Start()
    {

    }
    
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}