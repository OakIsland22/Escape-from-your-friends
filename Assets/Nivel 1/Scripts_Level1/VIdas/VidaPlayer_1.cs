using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class VidaPlayer_1 : MonoBehaviour
{
    public float vida;
    public int vidaMaxima = 6;

    public GameObject Perdiste_P1;

    public bool Moriste = false;

    public float shakeDuration = 0.1f;
    public float shakeMagnitude = 0.1f;

    private Vector3 originalPosition;
    private float shakeTimer = 0f;

    private void Start()
    {
        vida = vidaMaxima;
        originalPosition = transform.position;
    }

    private void Update()
    {
        Dead();

        if (vida < 0)
        {
            vida = 0;
        }

        if (shakeTimer > 0)
        {
            transform.position = originalPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            shakeTimer = 0f;
            transform.position = originalPosition;
        }
    }

    public void TomarDano(float dano)
    {
        vida -= dano;
        shakeTimer = shakeDuration;
    }

    public void Dead()
    {
        if (vida == 0)
        {
            Perdiste_P1.gameObject.SetActive(true);
            Moriste = true;
        }
    }
}
