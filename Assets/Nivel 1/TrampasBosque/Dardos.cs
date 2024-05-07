// Dardos.cs
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public int danoRecibir = 5;

    public VidaPlayer_1 VidaP1;
    public VidaPlayer_3 VidaP_3;

    private void Start()
    {
        VidaP1 = GameObject.FindGameObjectWithTag("Player_2").GetComponent<VidaPlayer_1>();
        VidaP_3 = GameObject.FindGameObjectWithTag("Player_3").GetComponent<VidaPlayer_3>();
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player_3"))
        {
            VidaP_3.TomarDano(danoRecibir);
        }
        if (other.gameObject.CompareTag("Player_2"))
        {
            VidaP1.TomarDano(danoRecibir);
        }
    }
}