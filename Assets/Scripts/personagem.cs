using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class personagem : MonoBehaviour {

    public float forcaImpulso;
    public static bool jogando;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        //Pega e define os componentes de RigidBody
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonDown ("Jump"))
        {
            // Define se o jogador está jogando
            if (!jogando)
            {
                Placar.Pontos = 0;
                rb.gravityScale = 1.0f;
                jogando = true;
            }

            //Impulsiona o personagem
            rb.velocity = new Vector2(0.0f, 0.0f);
            rb.AddForce(Vector2.up * forcaImpulso);

        }
        // Rotaciona o personagem
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * 2.0f);
		
	}

    // Define oque acontece quando colide com Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Placar.Pontos++;
    }
    //Define o que acontece quando colide com outras Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("start");
        jogando = false;
    }
}
