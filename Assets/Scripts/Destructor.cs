using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destructor : MonoBehaviour
{

    public static Explodable Explode(PolygonCollider2D collider, int fragments)
    {
        Explodable explodable = collider.gameObject.AddComponent<Explodable>();
        
        explodable.allowRuntimeFragmentation = true;
        explodable.shatterType = Explodable.ShatterType.Voronoi;
        explodable.extraPoints = fragments;
        explodable.explode();
        return explodable;
    }
    private void Awake()
    {
        GunShooter.OnColliderHit += OnColliderHit;
    }
    private void OnColliderHit(PolygonCollider2D collider)
    {
        DestroySmallFragments(Explode(collider, 5));
        
    }

    void DestroySmallFragments(Explodable explodable)
    {
        for (int i = 0; i < explodable.fragments.Count; i++)
        {
            if(explodable.fragments[i].GetComponent<MeshRenderer>() != null)
            {
                if(explodable.fragments[i].GetComponent<MeshRenderer>().bounds.size.x < 0.2f && explodable.fragments[i].GetComponent<MeshRenderer>().bounds.size.y < 0.2f)
                {
                    Destroy(explodable.fragments[i].gameObject);
                }
            }
        }
    }
}


