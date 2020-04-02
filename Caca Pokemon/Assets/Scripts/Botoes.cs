using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
   public void AbrirConfiguracoes()
    {
        SceneManager.LoadScene("Cenaconfiguracoes");
    }

    public void AbrirInicio()
    {
        SceneManager.LoadScene("CenaInicio");
    }

    public void AbrirJogo()
    {
        SceneManager.LoadScene("CenaJogo");
    }

    public void AbrirTutorial()
    {
        SceneManager.LoadScene("CenaTutorial");
    }

    public void AbrirRanking()
    {
        SceneManager.LoadScene("CenaRanking");
    }

    public void AbrirFim()
    {
        SceneManager.LoadScene("CenaFim");
    }

    public void EncerrarJogo()
    {
        Application.Quit();
    }
}
