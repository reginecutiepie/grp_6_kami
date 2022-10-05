using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class settingsmenuscript : MonoBehaviour
{
    public static settingsmenuscript settingsMenuscript;
    public TMP_InputField inputfield1;
    public TMP_InputField inputfield2;
    public TMP_InputField inputfield3;
   
    public string player1_name;
    public string player2_name;
    public string player_hp;

    public int intplayer_hp;

    private void Awake()
    {
        if (settingsMenuscript == null)
        {
            settingsMenuscript = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerNameAndHP()
    {
        player1_name = inputfield1.text;
        player2_name = inputfield2.text;

        player_hp = inputfield3.text;
        intplayer_hp = int.Parse(inputfield3.text);
    }
        
}
