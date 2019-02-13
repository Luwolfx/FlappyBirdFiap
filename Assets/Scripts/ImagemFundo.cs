using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagemFundo : MonoBehaviour {

	public float LimiteX;
	public float RetornarX;
	public float Velocidade;
	
	// Update is called once per frame
	void Update () {

        //Move o fundo na velocidade atribuida.
        transform.Translate(Vector2.left * Velocidade * Time.deltaTime);

		//Reposiciona a imagem
		if (transform.position.x < LimiteX) {
            transform.position = new Vector3(RetornarX, 0.0f, 0.0f);
		}

	}
}
