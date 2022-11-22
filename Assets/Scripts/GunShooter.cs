using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GunShooter : MonoBehaviour
{
    public static event Action<PolygonCollider2D> OnColliderHit;

    [SerializeField]
    GameObject projectilePrefab;

    [SerializeField]
    Transform endOfBarrel;

    [SerializeField]
    Animator animator;

    public bool Shoot()
    {
        Projectile projectile = GameObject.Instantiate(projectilePrefab).GetComponent<Projectile>();
        projectile.Launch(endOfBarrel.position, transform.forward,1);
        animator.SetTrigger("Shoot");
        Ray2D ray = new Ray2D(endOfBarrel.position, transform.right);
        Debug.DrawRay(endOfBarrel.position, transform.right,Color.red,1);
        RaycastHit2D hit = Physics2D.Raycast(endOfBarrel.position, transform.right, 5f);
        bool colliderHit = hit.collider != null && hit.collider.GetType() == typeof(PolygonCollider2D);
        if (colliderHit)
        {
            OnColliderHit?.Invoke(hit.collider as PolygonCollider2D);
        }

        return colliderHit;
    }


    private void Update() {
        if (Input.GetMouseButtonDown(0)) { Shoot(); }
    }


}
