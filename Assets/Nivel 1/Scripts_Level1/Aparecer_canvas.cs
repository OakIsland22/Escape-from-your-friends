using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Aparecer_canvas : MonoBehaviour
{
    public Image image;
    public TextMeshProUGUI text;

    public float fadeSpeed = 1.0f;
    private bool appearing = false;

    void OnEnable()
    {
        // Inicia el efecto de aparici�n cuando el GameObject se activa
        StartFadeIn();
    }

    void Update()
    {
        if (appearing)
        {
            FadeIn();
        }
    }

    void StartFadeIn()
    {
        // Asegura que los componentes sean transparentes al inicio
        SetInitialTransparency();

        // Activa el efecto de aparici�n
        appearing = true;        
        TiempoReal(); // Si necesitas ajustar el Time.timeScale
    }

    void SetInitialTransparency()
    {
        Color imageColor = image.color;
        Color textColor = text.color;
        imageColor.a = 0f;
        textColor.a = 0f;
        image.color = imageColor;
        text.color = textColor;
    }

    public void FadeIn()
    {
        Color imageColor = image.color;
        Color textColor = text.color;

        // Incrementa alpha hacia 1
        imageColor.a += fadeSpeed * Time.deltaTime;
        textColor.a += fadeSpeed * Time.deltaTime;

        // Asegura que los valores de alpha no excedan 1
        imageColor.a = Mathf.Clamp(imageColor.a, 0, 1);
        textColor.a = Mathf.Clamp(textColor.a, 0, 1);

        image.color = imageColor;
        text.color = textColor;

        // Detiene el efecto de aparici�n una vez que los elementos son completamente visibles
        if (imageColor.a >= 1f)
        {
            appearing = false;
        }
    }

    private void TiempoReal()
    {
        Time.timeScale = 1.0f;
    }
}
