using UnityEngine.Events;
using UnityEngine;
public class ColetavelMoeda : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeitoColeta;

    private bool foiColetado = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (foiColetado) return;

        if (other.CompareTag("Player"))
        {
            foiColetado = true;

            gameManager.AddPoints(1);

            if (efeitoColeta != null)
            {
                Instantiate(efeitoColeta, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}