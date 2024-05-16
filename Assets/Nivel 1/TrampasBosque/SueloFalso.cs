using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloFalso : MonoBehaviour
{
    // Variable para controlar la activación de la trampa
    public bool trampaActivada = false;

    // Referencia al componente Collider del suelo
    private Collider colliderDelSuelo;

    // Referencia al componente Renderer del suelo para hacerlo desaparecer
    private Renderer rendererDelSuelo;

    // Referencia al objeto que caerá y aplastará al jugador
    public GameObject objetoAplastador;
    public GameObject objetoAplastador2;
    // Daño que se aplicará al jugador al activar la trampa
    public int dano = 10;
    public VidaPlayer_1 player_2;
    public VidaPlayer_3 player_3 ;
    public Activar_trampa activar_Trampa;

    void Start()
    {
        // Inicializar las referencias
        colliderDelSuelo = GetComponent<Collider>();
        rendererDelSuelo = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        // Verificar si la trampa ha sido activada
        if (activar_Trampa.activarTrampa == true)
        {
            ActivarTrampa();
        }
    }

    void ActivarTrampa()
    {
        // Desactivar el collider para que los objetos caigan
        colliderDelSuelo.enabled = false;

        // Hacer desaparecer el suelo visualmente
        rendererDelSuelo.enabled = false;

        // Instanciar el objeto aplastador y hacerlo caer
        Instantiate(objetoAplastador, transform.position, Quaternion.identity);

        // Aplicar daño al jugador solo si esta en la trampa

       
        if (player_3 != null)
        {
            player_3.TomarDano(dano);
        }

       
        if (player_2 != null)
        {
            player_2.TomarDano(dano);
        }
        // Aquí puedes añadir más lógica, como reproducir un sonido o animación
    }

    // Método para activar la trampa desde otro script o evento
    public void Activar()
    {
        trampaActivada = true;
    }
}
