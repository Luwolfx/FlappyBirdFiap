using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Botao : MonoBehaviour
{

    public Button botaoInicio;
    Button btn;

    // Use this for initialization
    void Start()
    {
        //Define o botão e a parte de sua ação
        btn = botaoInicio.GetComponent<Button>();
        btn.onClick.AddListener(EntrarNoJogo);
    }

    //Parte da ação do botão, define o que ele vai fazer
    void EntrarNoJogo()
    {
        //Muda a cena para a cena do jogo
        SceneManager.LoadScene("Gameplay");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

