using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAimer : MonoBehaviour
{
    [SerializeField]
    Transform aim;

    void Update()
    {
        LookAt(aim.position);
    }


    void LookAt(Vector3 target)
    {
        // LookAt 2D

        // get the angle
        Vector3 norTar = (target - transform.position).normalized;

        Vector2 offset = new Vector2(norTar.x,norTar.y);
        float angle = Mathf.Atan2(norTar.y, norTar.x) * Mathf.Rad2Deg;
        // rotate to angle
        Quaternion rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, angle);
        transform.rotation = rotation;

    }
}
