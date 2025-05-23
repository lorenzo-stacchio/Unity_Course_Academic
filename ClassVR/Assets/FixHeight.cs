using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixHeight : MonoBehaviour
{

    [SerializeField]
    private GameObject mimickHeight;


    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.mimickHeight.transform.position.y, this.gameObject.transform.position.z);
    }
}
