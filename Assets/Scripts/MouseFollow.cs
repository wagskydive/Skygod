using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseFollow : MonoBehaviour
{
    [SerializeField]
    Camera sceneCamera;
    void FixedUpdate()
    {   
        Vector3 mp =sceneCamera.ScreenToWorldPoint(Input.mousePosition);
        transform.position =  mp;
    }
}
