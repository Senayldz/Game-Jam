using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
public ControllerInput _controller;
[Range(-10,200)]
public float Speed = 1.0f;
public Transform saniyeRotation;
public Transform yelkovanRotation;
public Transform akrepRotation;

void Update()
{
    Saniye();
    Akrep();
    Yelkovan();
}
void Saniye()
{
    saniyeRotation.Rotate(Vector3.up, (Time.deltaTime * 5.5f * _controller.Look.y * _controller.Look.x) * Speed);
}
void Yelkovan()
{
    yelkovanRotation.Rotate(Vector3.up, ((Time.deltaTime * 5.5f * _controller.Look.y * _controller.Look.x) / 60.0f) * Speed);
}
void Akrep()
{
    akrepRotation.Rotate(Vector3.up, ((Time.deltaTime * 5.5f * _controller.Look.y * _controller.Look.x) / 720.0f) * Speed);
}

}
