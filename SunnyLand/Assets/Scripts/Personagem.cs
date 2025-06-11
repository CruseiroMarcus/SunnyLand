using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nomePersonagem = "Raposa";
    public int vidas = 5;
    private int velocidade = 1;
    private bool vivo = true;

    private Rigidbody2D rb;
    public float novaGravidade = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nome do personagem:\n" + nomePersonagem + "\n Vidas:\n" + vidas
                 + "\n Velocidade do personagem:\n" + velocidade + "\n Vivo ou Morto:\n" + vivo);

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
