using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Criador : MonoBehaviour
{

    public GameObject Pokemon;

    public Text contador;

    private float tempoRestante = 60f;

    private int limite = 10;

    public Pokemon[] pokemons;

    private int quantidade = 5;

    public Text pontosVisor;
    
    private int pontosJogador = 0;

    public void AumentarPontos()
    {
        pontosJogador++;
        pontosVisor.text = "Pontos: " + pontosJogador;
    }

    public void ChocaPokemon()
    {

       
        pokemons = FindObjectsOfType<Pokemon>();
        if(pokemons.Length < limite)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Vector3 pokemonPosicao = new Vector3(Random.Range(-6f, 6f), Random.Range(-3f, 3f), 0f);
                Instantiate(Pokemon, pokemonPosicao, Quaternion.identity);
            }
        }
       

    }



    void Start()
    {
        InvokeRepeating("ChocaPokemon", 0.0f, 2.0f);
    }


    void Update()
    {
        tempoRestante -= Time.deltaTime;
        contador.text = "TEMPO RESTANTE \n" + Mathf.Round(tempoRestante) + " SEGUNDOS";

        if (tempoRestante < -5)
        {
            PlayerPrefs.SetInt("PontosAtual", pontosJogador);
            SceneManager.LoadScene("CenaFim");
        }
        else if (tempoRestante < 0)
        {
            contador.text = "TEMPO\nESGOTADO";
        }
        else if (tempoRestante < 10)
        {
            limite = 50;
            quantidade = 15;
            contador.color = Color.red;

        }
        else if (tempoRestante < 30)
        {
            limite = 20;
            quantidade = 10;
            contador.color = Color.yellow;
        }
    }

}




   
