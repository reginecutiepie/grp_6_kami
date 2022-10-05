using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;  

public class Nameholderscript : MonoBehaviour
{
    public TextMeshProUGUI display_player1_name;
    public TextMeshProUGUI display_player2_name;

    public void Awake ()
    {
        display_player1_name.text = settingsmenuscript.settingsMenuscript.player1_name;
         display_player2_name.text = settingsmenuscript.settingsMenuscript.player2_name;
    }
}

