using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManagerProjectle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        Debug.Log("COLLISION " +  collided.gameObject.name.ToString());
        if (collided.tag == "Shootable")
        {
            GameObject.Destroy(collided);
        }
    }
}
