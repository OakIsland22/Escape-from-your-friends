using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Este método se llama cuando el jugador selecciona 'Jugar'
    public void PlayGame()
    {
        // Intenta cargar la escena del juego y maneja cualquier error que pueda ocurrir
       SceneManager.LoadScene("Demo_scene");
    }

    // Este método se llama cuando el jugador selecciona 'Opciones'
    public void OpenOptions()
    {
        SceneManager.LoadScene("MenuOpciones");
    }

    // Este método se llama cuando el jugador selecciona 'Salir'
    public void QuitGame()
    {
        // Cierra la aplicación
        Application.Quit();
    }

    // Método para cargar escenas de forma segura
   
}
