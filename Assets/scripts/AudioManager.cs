using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer AudioMixer;

    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("MasterVolume", volume);
    }

    // A�ade m�s m�todos seg�n sea necesario para controlar otros aspectos del audio
}
