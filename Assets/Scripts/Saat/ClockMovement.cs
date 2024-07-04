using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMovement : MonoBehaviour
{
    [Range(-1,200)]
    public float Speed = 4;
    public Transform saatParcalar;
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, (Time.deltaTime * 5.5f) * Speed);

        saatParcalar.transform.Rotate(Vector3.up, (Time.deltaTime * 5.5f) * Speed);
    }
}
