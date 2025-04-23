﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateHouse : MonoBehaviour
{
    //private void Awake()
    //{
    //    this.SetAbsoluteRotation(90.0f);
    //}

    [SerializeField]
    private GameObject Slider;

    private Slider sliderProperty;

    // Start is called before the first frame update
    void Start()
    {
        this.sliderProperty = this.Slider.GetComponent<Slider>();

        this.sliderProperty.onValueChanged.AddListener(delegate (float x) { this.SetAbsoluteRotation(x); });
        this.sliderProperty.onValueChanged.AddListener(delegate (float x) { Debug.Log("I listener non sono poi così difficili."); });


    }

    // Update is called once per frame
    void Update()
    {

    }


    // Funzione che setta la rotazione assoluta dell'oggetto lungo l'asse delle x.

    // xRotationAsbolute -- [0,1] ---- > [0,360]

    public void SetAbsoluteRotation(float xRotationAsbolute)
    {

        //Vector3 newRotation = new Vector3(xRotationAsbolute * 360.0f, 0,0);
        //float newValue = Random.Range(180.0f, 360.0f);
        float start = 180.0f;
        float end = 360.0f; 
        
        float newValue = start + (end-start) * Random.Range(0.0f, 1.0f); 
        
        //Random.Range(0.0f, 90.0f);
        


        Vector3 newRotation = new Vector3(xRotationAsbolute * newValue, 0, 0);

        this.transform.rotation = Quaternion.Euler(newRotation);
    }
}
