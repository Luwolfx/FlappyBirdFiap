using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour {

    public Text txtPontos;
    public static int Pontos;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        txtPontos.text = Pontos.ToString();
	}
}
