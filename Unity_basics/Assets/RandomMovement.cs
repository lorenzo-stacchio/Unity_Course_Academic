using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed = 5.0f;
    float min = -10.0f;
    float max = 20.0f;
    Vector3 move; 

    private void Start()
    {
        this.move = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(this.move * moveSpeed * Time.deltaTime);
        if (transform.position.x > max || transform.position.x < min) 
        {
            this.move = new Vector3(-1* this.move.x, 0, 0);
        }
    }


}
