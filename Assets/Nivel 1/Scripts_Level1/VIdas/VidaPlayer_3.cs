using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VidaPlayer_3 : MonoBehaviour
{
    public float vida = 100;
    public float vidaMaxima = 100;

    public GameObject Perdiste_P2;

    public bool Moriste = false;

    public float shakeDuration = 0.1f;
    public float shakeMagnitude = 0.1f;

    private Vector3 originalPosition;

    private void Start()
    {
        vida = vidaMaxima;
        originalPosition = transform.position;
    }

    private void Update()
    {
        Dead();

        if (vida <= 0)
        {
            vida = 0;
        }
    }

    public void TomarDano(float dano)
    {
        vida -= dano;
        StartCoroutine(ShakeCamera());
    }

    public void Dead()
    {
        if (vida == 0)
        {
            Perdiste_P2.gameObject.SetActive(true);
            Moriste = true;
        }
    }

    private IEnumerator ShakeCamera()
    {
        float elapsed = 0f;

        while (elapsed < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitude;
            float y = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.position = originalPosition + new Vector3(x, y, 0f);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.position = originalPosition;
    }
}
