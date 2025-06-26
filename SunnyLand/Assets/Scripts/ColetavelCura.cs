using UnityEngine;
public class ColetavelCura : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeitoCura;

    private bool foiColetado = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (foiColetado) return;

        if (collision.CompareTag("Player"))
        {
            foiColetado = true;

            gameManager.Heal();

            if (efeitoCura != null)
            {
                Instantiate(efeitoCura, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}