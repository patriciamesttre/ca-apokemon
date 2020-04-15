using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public Text pontuacao;
    
    public InputField nome;

    public void Salvar()
    {
        PlayerPrefs.SetString("NomeJogador", nome.text);
        pontuacao.text = "Pontuação\n" + PlayerPrefs.GetString("NomeJogador") + " : " + PlayerPrefs.GetInt("PontosAtual");
        nome.text = " ";
;
        SceneManager.LoadScene("CenaRanking");
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pontos: " + PlayerPrefs.GetInt("PontosAtual"));  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
