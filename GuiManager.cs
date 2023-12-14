using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuiManager : MonoBehaviour
{
    public LoadSaveGame loadSaveGame;
    public TMP_Text textMeshPro;
    public MainManager mainManager;
    
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.text = "Best Score: " + loadSaveGame.score.ToString() + " Name: " + loadSaveGame.gamerName;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainManager.m_Points > loadSaveGame.score) 
        {
            loadSaveGame.score = mainManager.m_Points;
            loadSaveGame.SalvaDados();
        }
    }
}
