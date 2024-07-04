using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public  Animator playerAnimator;
    public ControllerInput _input;

    public AudioClip jumpClip;
    public AudioClip runClip;
    public AudioClip hitClip;
    public AudioSource playerAudioS;

    public Rigidbody playerRigidb;
    float Speed = 1;
    public float jumpSpeed;
    private float Timer = 0f;
    public float movementspeed = 0f;
    private float Cooldown = 0.6f;
    public bool startG = false;
    public float realTime=0;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        _input = GetComponent<ControllerInput>();
        playerRigidb = GetComponent<Rigidbody>();
        playerAudioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        realTime += Time.deltaTime;
        if(startG == false && realTime > 1){
            startG = true;
        }
        playerAnimator.SetFloat("Speed", Speed);
        playerAnimator.SetFloat("Horizontal", _input.MovementValue.x, 0.1f, Time.deltaTime);
        if(_input.Esc){
            SceneManager.LoadScene("Menu");
        }
    }
    void FixedUpdate()
    {
        Vector3 move = new Vector3(_input.MovementValue.x, 0, 0) * Time.deltaTime * movementspeed;
        playerRigidb.MovePosition(transform.position + transform.TransformDirection(move));
    }
    void Jump()
    {
        playerRigidb.velocity = Vector3.up * Time.deltaTime * jumpSpeed;
        playerAnimator.SetTrigger("Jump");
    }
    void OnTriggerStay(Collider other)
    {   
        if(startG){
        if(other.gameObject.CompareTag("Zemin") &&(_input.Jump) && Time.time > Timer)
        {
        playerAudioS.Stop();
        Jump();
        playerAudioS.PlayOneShot(jumpClip);
        Timer = Time.time + Cooldown;
        }
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Zemin"))
        {
            playerAudioS.PlayOneShot(runClip);
        }
        if(other.gameObject.CompareTag("Engel"))
        {
            playerAudioS.PlayOneShot(hitClip);
            Invoke("RestartGame",0.3f);
            
        }
    }

    void RestartGame(){

        SceneManager.LoadScene("Game");
    }

}
