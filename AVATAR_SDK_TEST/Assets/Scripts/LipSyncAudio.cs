using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LipSyncAudio : MonoBehaviour
{

       // this is from the child object
    [SerializeField]
    private AudioSource? _audioSource;

    private bool applyUpdateLogic = false;

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
        StartCoroutine(slowPlay(1));
    }

    // Update is called once per frame
    void Update()
    {
        if (applyUpdateLogic)
        {
            AudioSource temp = this.GetComponent<AudioSource>();
            temp.loop = false;
            _audioSource.loop = false;
        }
        
    }

    public IEnumerator slowPlay(float time)
    {
        yield return new WaitForSeconds(time);
        AudioSource temp = this.GetComponent<AudioSource>();
        temp.Play();
        _audioSource.Play();
        //_audioSource.loop = false;
        temp.loop = false;
        this.applyUpdateLogic = true;
        yield return null;
    }
}
