using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este m�todo se llama cuando el jugador selecciona 'Jugar'
    public void PlayGame()
    {
        // Intenta cargar la escena del juego y maneja cualquier error que pueda ocurrir
        SceneManager.LoadScene("Seleccion");
    }

    // Este m�todo se llama cuando el jugador selecciona 'Opciones'
    public void OpenOptions()
    {
        SceneManager.LoadScene("MenuOpciones");
    }
    // Este m�todo se llama cuando el jugador selecciona 'MainMenu'
    public void MenuInicial()
    {
        SceneManager.LoadScene("MainMenu");
    }
        // Este m�todo se llama cuando el jugador selecciona 'Controles'
    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
    // Este m�todo se llama cuando el jugador selecciona 'Salir'
    public void QuitGame()
    {
        // Cierra la aplicaci�n
        Application.Quit();
    }
    public void Confirm()
    {
        SceneManager.LoadScene("MainMenu2");
    }
}
