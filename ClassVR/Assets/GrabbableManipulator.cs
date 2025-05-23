using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;

public class GrabbableManipulator : MonoBehaviour
{

    [SerializeField]
    private GameObject GrabbableObject;

    [SerializeField]
    private TextMeshPro textToChange;

    [SerializeField]
    private Material materialToChangeState;

    private bool state;

    public void Start()
    {
        state = true;
    
    }

    public void OnStateChange()
    {

        this.state = ! state;

        if (state)
        {
            this.textToChange.text = "Grabbable Mode";
            this.materialToChangeState.color = new Color(0.0f, 255.0f, 0.0f);
            this.GrabbableObject.GetComponent<Grabbable>().enabled = true;
            this.GrabbableObject.GetComponentInChildren<HandGrabInteractable>().enabled = true;
            this.GrabbableObject.GetComponentInChildren<GrabInteractable>().enabled = true;

        }
        else {
            this.textToChange.text = "UnGrabbable Mode";
            this.materialToChangeState.color = new Color(255.0f, 0.0f, 0.0f);
            this.GrabbableObject.GetComponent<Grabbable>().enabled = false;
            this.GrabbableObject.GetComponentInChildren<HandGrabInteractable>().enabled = false;
            this.GrabbableObject.GetComponentInChildren<GrabInteractable>().enabled = false;
        }

        Debug.Log("Incredibile funziona");


    }
}
