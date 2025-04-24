using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float projectileSpeed = 20f;
    private GameObject camera;
    public GameObject projectilePrefab;
    private float fireInterval = 1f; // Time between shots in seconds
    private float nextFireTime = 0f;

    private void Start()
    {    
        this.camera = this.transform.Find("Main Camera").gameObject;
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            move += Vector3.forward;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            move += Vector3.back;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            move += Vector3.left;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            move += Vector3.right;

        if (Input.GetKey(KeyCode.Space)) { 
            if (Time.time >= nextFireTime)
            {
                Fire();
                nextFireTime = Time.time + fireInterval;
            }
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    public void Fire()
    {
        // Get the forward direction of the camera
        Vector3 forwardDirection = camera.transform.forward;

        // Instantiate the projectile at the camera's position and rotation
        GameObject projectile = Instantiate(projectilePrefab, camera.transform.position, Quaternion.LookRotation(forwardDirection));

        // Ensure the projectile has a Rigidbody component
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Set the velocity of the projectile to move it forward
            rb.velocity = forwardDirection * projectileSpeed;
        }
        else
        {
            Debug.LogWarning("Projectile prefab is missing a Rigidbody component.");
        }
    }



}
