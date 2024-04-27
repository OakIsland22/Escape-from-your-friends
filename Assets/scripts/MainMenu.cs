using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este m�todo se llama cuando el jugador selecciona 'Jugar'
    public void PlayGame()
    {
        // Intenta cargar la escena del juego y maneja cualquier error que pueda ocurrir
       SceneManager.LoadScene("Demo_scene");
    }

    // Este m�todo se llama cuando el jugador selecciona 'Opciones'
    public void OpenOptions()
    {
        // TODO: A�adir la l�gica para abrir el men� de opciones
    }

    // Este m�todo se llama cuando el jugador selecciona 'Salir'
    public void QuitGame()
    {
        // Cierra la aplicaci�n
        Application.Quit();
    }

    // M�todo para cargar escenas de forma segura
   
}
