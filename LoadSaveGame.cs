using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;

public class LoadSaveGame : MonoBehaviour
{
    
    public int score;
    
    
    public string gamerName;
    [SerializeField] TMP_Text printBox;
    
    public bool fileExiste;
    public string json;
    

    // Start is called before the first frame update
    void Start()
    {

        LoadDados();
    }





    [System.Serializable]
    class SaveData
    {
        public int score;
        //public int highScore;
        public string gamerName;
        //public int levelGame;
    }

    public void LoadDados()
    {
        //string path = Application.persistentDataPath + "/savefile.json";
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            fileExiste = true;
            //string json = File.ReadAllText(path);
            json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            print(data);
            gamerName = data.gamerName;
            score = data.score;
            
        }
        else { fileExiste = false; }
    }


    public void SalvaDados()
    {
        SaveData data = new SaveData();
       

        data.gamerName = gamerName.ToUpper();
        data.score = score;
        

       
        json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        PlayerPrefs playerPrefs = new PlayerPrefs();


        //playerPrefs = json;
    }

    public void salvaNovoJogador(string s)
    {

        gamerName = s;
        score = 0;
        SalvaDados();
    }

}

