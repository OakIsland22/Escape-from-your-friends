using UnityEngine;
using UnityEngine.Audio; // Necesario para el manejo del audio
using UnityEngine.UI; // Necesario para UI
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{
    public AudioMixer audioMixer; // Referencia al AudioMixer
    public Dropdown resolutionDropdown; // Referencia al Dropdown de resoluciones

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void BacktoMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Añade más métodos para otras opciones como resolución, controles, etc.
}
