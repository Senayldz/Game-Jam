using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClock : MonoBehaviour
{
    public ControllerInput _controller;
    public AudioClip gearClip;
    public AudioClip gameClip;
    public AudioSource playerAudioSource;
    void Start()
    {
        _controller= GetComponent<ControllerInput>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(playerAudioSource.isPlaying == false)
        {
            if(_controller.Look.x != 0 || _controller.Look.y != 0)
            {
                playerAudioSource.PlayOneShot(gearClip);
            }
        }
        if(_controller.Look.x == 0 || _controller.Look.y == 0){
            playerAudioSource.Stop();
        }
    }
}
