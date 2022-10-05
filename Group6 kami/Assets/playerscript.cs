using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    public GameObject player1HPUI;
    public GameObject player2HPUI;
    public int player1HP;
    public int player2HP;
    public int maxHealth;
    public Image healthbar1;
    public Image healthbar2;
    public VideoClip stvid;
    public GameObject attack;
    public VideoPlayer startingPos;
    public VideoPlayer vpAtk;
    public Button specialOne;
    public Button specialTwo;
    public VideoClip lowPunch1, highPunch1, lowKick1, highKick1, special1;
    public VideoClip lowPunch2, highPunch2, lowKick2, highKick2, special2;
    public VideoClip missLP1, missHP1, missLK1, missHK1;
    public VideoClip missLP2, missHP2, missLK2, missHK2;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = settingsmenuscript.settingsMenuscript.intplayer_hp;
        player1HP = maxHealth;
        player2HP = maxHealth;
        startingPos.gameObject.GetComponent<VideoPlayer>().clip = stvid;
        startingPos.gameObject.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        player1HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player1HP + "";
        player2HPUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
        UpdateHealthUI();

        if(player2HP <= 0 && healthbar1.GetComponent<Image>().fillAmount == 0){
            SceneManager.LoadScene(2);
        }else if(player1HP <= 0 && healthbar2.GetComponent<Image>().fillAmount == 0){
            SceneManager.LoadScene(3);
        }else{

        }
    }

    public void UpdateHealthUI()
    {
        healthbar1.fillAmount = (float)player1HP/(float)maxHealth;
        healthbar2.fillAmount = (float)player2HP/(float)maxHealth;
    }

    public void dealDamage(int damage, int playerHP, int playerNum){
        if (playerNum == 1)
        {
            playerHP -= damage;
            player2HP = playerHP;
            Debug.Log("Aguy");
        }

        else
        {
            playerHP -= damage;
            player1HP = playerHP;
            Debug.Log("Ouch Pain");
        }
    }

    public IEnumerator delayPress(int playerNum, int attackNum, int accuracy){
        int x = Random.Range(0,100);
        if (x <= accuracy){
            if (playerNum == 1){
                switch (attackNum){
                    case 1:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    dealDamage(3, player2HP, 1);
                    break;
                    
                    case 2:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    dealDamage(8, player2HP, 1);
                    break;

                    case 3:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    dealDamage(6, player2HP, 1);
                    break;

                    case 4:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    dealDamage(12, player2HP, 1);
                    break;

                    case 5:
                    yield return new WaitForSeconds(0.35f);                 
                    attack.SetActive(true);
                    yield return new WaitForSeconds(5);
                    attack.SetActive(false);
                    dealDamage(25, player2HP, 1);
                    break;
                }
            }else{
                switch (attackNum){
                    case 1:
                    yield return new WaitForSeconds(0.35f);                
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    dealDamage(3, player1HP, 2);
                    break;
                    
                    case 2:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    dealDamage(8, player1HP, 2);
                    break;

                    case 3:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    dealDamage(6, player1HP, 2);
                    break;

                    case 4:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    dealDamage(12, player1HP, 2);
                    break;

                    case 5:
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(5);
                    attack.SetActive(false);
                    dealDamage(25, player1HP, 2);
                    break;
                }
            }
        }else{
            if (playerNum == 1){
                switch (attackNum){
                    case 1:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missLP1;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    
                    break;
                    
                    case 2:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missHP1;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    break;

                    case 3:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missLK1;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    break;

                    case 4:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missHK1;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    break;
                }
            }else{
                switch (attackNum){
                    case 1:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missLP2;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    break;
                    
                    case 2:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missHP2;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    break;

                    case 3:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missLK2;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    attack.SetActive(false);
                    break;

                    case 4:
                    vpAtk.gameObject.GetComponent<VideoPlayer>().clip = missHK2;
                    vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
                    yield return new WaitForSeconds(0.35f);
                    attack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    attack.SetActive(false);
                    break;
                }
            }
        }
    }

    public void lowPunchP1(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = lowPunch1;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,1,75));
    }

    public void highPunchP1(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = highPunch1;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,2,55));
    }

    public void lowKickP1(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = lowKick1;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,3,65));
    }
    public void highKickP1(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = highKick1;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,4,45));
    }

    public void specialP1 (){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = special1;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(1,5,100));
        specialOne.interactable = false;
    }

    public void lowPunchP2(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = lowPunch2;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,1,75));
    }

    public void highPunchP2(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = highPunch2;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,2,55));
    }

    public void lowKickP2(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = lowKick2;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,3,65));
    }
    public void highKickP2(){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = highKick2;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,4,45));
    }

    public void specialP2 (){
        vpAtk.gameObject.GetComponent<VideoPlayer>().clip = special2;
        vpAtk.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayPress(2,5,100));
        specialTwo.interactable = false;
    }


}
