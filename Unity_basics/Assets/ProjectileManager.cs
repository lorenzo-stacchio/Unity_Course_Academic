using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    // Start is called before the first frame update

    float projectileSpeed = 2.0f;


    public void SetDirectionalVelocity(Vector3 direction)
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = direction * projectileSpeed;
    }

}
