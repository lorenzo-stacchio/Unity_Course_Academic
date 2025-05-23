using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereMagic : MonoBehaviour
{

    [SerializeField]
    private GameObject object1;
    [SerializeField]
    private GameObject object2;

    public void OnGrab()
    {
        this.object1.SetActive(false);
        this.object2.SetActive(true);
    }



    public void OnGrabRelease()
    {
        this.object1.SetActive(true);
        this.object2.SetActive(false);
    }



}
