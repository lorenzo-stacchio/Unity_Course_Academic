using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [Range(2, 10), SerializeField]
    private float velocity;

    private Vector3 direction;
    [SerializeField]
    private GameObject leftBoundary;
    [SerializeField]
    private GameObject rightBoundary;

    // Start is called before the first frame update
    void Start()
    {
        this.direction = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= leftBoundary.transform.position.x || this.transform.position.x >= rightBoundary.transform.position.x)
        {
            this.direction *= -1;
        }
        this.transform.position += (direction * velocity * Time.deltaTime);
        Debug.Log(this.transform.position);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
        }
    }


    public void SetReference(GameObject leftWall, GameObject rightWall)
    {
        this.leftBoundary = leftWall;
        this.rightBoundary = rightWall;

    }

}
