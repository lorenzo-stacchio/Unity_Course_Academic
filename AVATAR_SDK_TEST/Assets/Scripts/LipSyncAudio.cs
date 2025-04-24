using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LipSyncAudio : MonoBehaviour
{

       // this is from the child object
    [SerializeField]
    private AudioSource? _audioSource;

    // Start is called before the first frame update
    void Awake()
    {
        //this is the audio attached
        AudioSource temp = this.GetComponent<AudioSource>();
        temp.clip = _audioSource.clip;
        temp.loop = false;
    }

    void Start()
    {
        //this is the audio attached
        AudioSource temp = this.GetComponent<AudioSource>();
        temp.Play();
        temp.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource temp = this.GetComponent<AudioSource>();
        temp.loop = false;
        _audioSource.loop = false;
    }
}
