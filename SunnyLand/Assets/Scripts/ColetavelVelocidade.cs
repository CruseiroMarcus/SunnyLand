using UnityEngine.Events;
using UnityEngine;
public class ColetavelVelocidade : MonoBehaviour
{
    public GameManager gameManager;
    public float aumento = 10f;
    public ParticleSystem efeitoVelocidade;

    private bool foiColetado = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (foiColetado) return;

        if (collision.CompareTag("Player"))
        {
            foiColetado = true;

            PlayerMovement movimento = collision.GetComponent<PlayerMovement>();
            if (movimento != null)
            {
                movimento.runSpeed += aumento;
            }

            if (efeitoVelocidade != null)
            {
                Instantiate(efeitoVelocidade, transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}