using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coletavel : MonoBehaviour
{
    public TMP_Text texto_pontos;
    public ParticleSystem efeito;
    int pontos = 0;

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            pontos++;
            texto_pontos.text = "Pontos: " + pontos.ToString();
            outro.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
        }
    }
    
              
 }

