using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public LoadSaveGame loadSaveGame;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GamePrincipal()
    {
       
        SceneManager.LoadScene("main");

       

    }



   





    public void SairBotao()
    {
        Debug.Log("Botao sair");
        StartCoroutine(EsperarSegundos(3.0f));
        Application.Quit();
    }

    IEnumerator EsperarSegundos(float segundos)
    {
        Debug.Log("Inicio da espera");

        yield return new WaitForSeconds(segundos); // Pausa por 'segundos' segundos

        Debug.Log("Espera concluida apos " + segundos + " segundos");
    }


}
