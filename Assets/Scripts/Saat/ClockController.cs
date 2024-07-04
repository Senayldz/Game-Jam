using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
[Range(-10,200)]
public float Speed = 1.0f;
public float time = 0;
public Transform saniyeRotation;
public Transform yelkovanRotation;
public Transform akrepRotation;

public AudioSource audioSource;

public AudioClip gearClip;

void Update()
{
    time += Time.deltaTime;
    Saniye();
    Akrep();
    Yelkovan();
}
void Saniye()
{
    saniyeRotation.Rotate(Vector3.up, (Time.deltaTime * 5.5f) * Speed);
}
void Yelkovan()
{
    yelkovanRotation.Rotate(Vector3.up, ((Time.deltaTime * 5.5f) / 60.0f) * 20);
}
void Akrep()
{
    akrepRotation.Rotate(Vector3.up, ((Time.deltaTime * 5.5f) / 720.0f) * Speed);
}

}
