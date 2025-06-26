using UnityEngine.Events;
using UnityEngine;

public class ColetavelDano : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeitoDano;
    public float danoCooldown = 10f; 
    private float proximoDanoTempo; 

    private void OnTriggerStay2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            
            if (Time.time >= proximoDanoTempo)
            {
                gameManager.RemoveLife(); 
                Debug.Log("Dano causado! Vidas restantes: " + gameManager.lives); 

                if (efeitoDano != null)
                {
                    Instantiate(efeitoDano, transform.position, Quaternion.identity);
                }

                
                proximoDanoTempo = Time.time + danoCooldown;
            }
        }
    }

    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            proximoDanoTempo = Time.time; 
        }
    }
}