using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerManagerTemp : MonoBehaviour
{
    [Range(1,5)]
    public float velocity;

    [SerializeField]
    private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            move = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            move = Vector3.back;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            move = Vector3.right;
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            move = Vector3.left;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera camera = this.transform.Find("Camera").GetComponent<Camera>();

            Vector3 direction = camera.gameObject.transform.forward;

            GameObject projectile_temp = Instantiate(projectile, camera.gameObject.transform.position, Quaternion.LookRotation(direction));
            
            projectile_temp.GetComponent<ProjectileManager>().SetDirectionalVelocity(direction);

            //GameObject proj = Instantiate(projectile, camera.gameObject.transform.position, Quaternion.LookRotation(camera.gameObject.transform.forward));
            //proj.transform.Rotate(90, 0, 0);
            //proj.GetComponent<ProjectileManager>().SetDirectionalVelocity(camera.gameObject.transform.forward);
        }

        Debug.Log("Direction is: " +  move.ToString());

        this.transform.position += (move * velocity * Time.deltaTime);
    }




}
