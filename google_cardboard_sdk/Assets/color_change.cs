using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColorChange()
    {
        MeshRenderer mat = this.GetComponent<MeshRenderer>();
        mat.material.color = new Color(Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f), Random.RandomRange(0f, 1f), 1);
    }
}
