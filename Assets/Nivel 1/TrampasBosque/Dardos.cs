// Dardos.cs
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public int danoRecibir = 5;

    public VidaPlayer_1 VidaP1;
    public VidaPlayer_3 VidaP_3;


    private float damageCooldown = 2f;  
    private float nextDamageTimeP2 = 0f;
    private float nextDamageTimeP3 = 0f;
    private void Start()
    {
        VidaP1 = GameObject.FindGameObjectWithTag("Player_2").GetComponent<VidaPlayer_1>();
        VidaP_3 = GameObject.FindGameObjectWithTag("Player_3").GetComponent<VidaPlayer_3>();
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player_3") && Time.time >= nextDamageTimeP3)
        {
            VidaP_3.TomarDano(danoRecibir);
            nextDamageTimeP3 = Time.time + damageCooldown;
            gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Player_2") && Time.time >= nextDamageTimeP2)
        {
            VidaP1.TomarDano(danoRecibir);
            nextDamageTimeP2 = Time.time + damageCooldown;
            gameObject.SetActive(false);
        }
    }
}