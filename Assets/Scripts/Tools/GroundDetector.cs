using UnityEngine;
using System;

[RequireComponent(typeof(Collider2D))]
public class GroundDetector : MonoBehaviour
{


    [SerializeField]
    float groundTreshold = .1f;

    public event Action OnIsOnGround;
    public event Action OnIsNotOnGround;
    bool isOnGround;

    public bool IsOnGround { get => isOnGround; }

    [SerializeField]
    Transform raycastStart;

    Collider2D detectionCollider;
    private void Awake()
    {
        if (raycastStart == null)
        {
            raycastStart = transform;
        }
        detectionCollider = GetComponent<Collider2D>();
    }
    float TerrainDistance()
    {
        return 0;
    }
    private void Update()
    {
        CheckForGround();
    }

    private void CheckForGround()
    {

        RaycastHit2D hit = Physics2D.Raycast(raycastStart.position, Vector2.down, 1f);
        if (hit.collider != detectionCollider)
        {
            float distance = Vector2.Distance(raycastStart.position, hit.point);
            //Debug.Log("Distance: " + distance);
            if (distance < groundTreshold)
            {

                if (!isOnGround)
                {
                    SetOnGround();
                }
            }
            else
            {
                if (isOnGround)
                {
                    SetNotOnGround();
                }
            }
        }
        else
        {
            if (isOnGround)
            {
                SetNotOnGround();
            }
        }
    }

    private void SetNotOnGround()
    {
        isOnGround = false;
        OnIsNotOnGround?.Invoke();
    }


    private void SetOnGround()
    {
        isOnGround = true;
        OnIsOnGround?.Invoke();
    }


}

