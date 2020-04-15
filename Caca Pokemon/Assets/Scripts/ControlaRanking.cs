using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlaRanking : MonoBehaviour
{
    public Text listaCampeoes;

    // Start is called before the first frame update
    void Start()
    {
        /*PlayerPrefs.SetString("NomeJogador1", "João");
        PlayerPrefs.SetInt("PontosJogador1", 300);

        PlayerPrefs.SetString("NomeJogador2", "Maria");
        PlayerPrefs.SetInt("PontosJogador2", 50);

        PlayerPrefs.SetString("NomeJogador3", "Renata");
        PlayerPrefs.SetInt("PontosJogador3", 100);*/

        MontaListaCampeoes();
    }

    void MontaListaCampeoes()
    {
        string suaPontuacao = "";

        if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador1"))
        {
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosJogador1"));
            PlayerPrefs.SetInt("PontosJogador1", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador2"));
            PlayerPrefs.SetString("NomeJogador2", PlayerPrefs.GetString("NomeJogador1"));
            PlayerPrefs.SetString("NomeJogador1", PlayerPrefs.GetString("NomeJogador"));

        }else if(PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador2")){
            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosJogador2"));
            PlayerPrefs.SetInt("PontosJogador2", PlayerPrefs.GetInt("PontosAtual"));

            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador2"));
            PlayerPrefs.SetString("NomeJogador2", PlayerPrefs.GetString("NomeJogador"));
        }
        else if (PlayerPrefs.GetInt("PontosAtual") > PlayerPrefs.GetInt("PontosJogador3"))
        {

            PlayerPrefs.SetInt("PontosJogador3", PlayerPrefs.GetInt("PontosAtual"));
            PlayerPrefs.SetString("NomeJogador3", PlayerPrefs.GetString("NomeJogador"));

        }
        else
        {
            suaPontuacao = "\nSua Pontuação: " + PlayerPrefs.GetInt("PontosAtual");
        }





        listaCampeoes.text = "1° - " + PlayerPrefs.GetString("NomeJogador1");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador1");

        listaCampeoes.text += "\n2° - " + PlayerPrefs.GetString("NomeJogador2");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador2");

        listaCampeoes.text += "\n3° - " + PlayerPrefs.GetString("NomeJogador3");
        listaCampeoes.text += " - " + PlayerPrefs.GetInt("PontosJogador1");

        listaCampeoes.text += suaPontuacao;

        PlayerPrefs.SetString("NomeJogador", "");
        PlayerPrefs.SetInt("PontosAtual", 0);
    }

    public void LimparRanking()
    {

        PlayerPrefs.SetString("NomeJogador1", "");
        PlayerPrefs.SetInt("PontosJogador1", 0);

        PlayerPrefs.SetString("NomeJogador2", "");
        PlayerPrefs.SetInt("PontosJogador2", 0);

        PlayerPrefs.SetString("NomeJogador3", "");
        PlayerPrefs.SetInt("PontosJogador3", 0);
        listaCampeoes.text = "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
