using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    public float velocidade;
    public float limiteSuperior, limiteInferior;
    Vector3 posicaoInicial;
    float limiteX;

    // Use this for initialization
    void Start()
    {
        //Define sua posição inicial e o limite oposto da tela.
        posicaoInicial = transform.position;
        limiteX = -8;

    }

    // Update is called once per frame
    void Update()
    {

        //Verifica se o personagem está jogando.
        if (personagem.jogando == true)
        {
            // Faz o cano andar
            transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        }
        // Define o limite
        if (transform.position.x < limiteX)
            {
                //Volta a posição inicial
                transform.position = new Vector2(
                posicaoInicial.x,
                //Aleatoriza a abertura
                Random.Range(limiteInferior, limiteSuperior)
                );
            }
        
    }
}

