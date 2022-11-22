using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    public void Launch(Vector3 position, Vector3 direction, float speed)
    {
        transform.position = position;
        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        //rb.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
    }
}
