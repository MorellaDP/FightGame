using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameScene : MonoBehaviour
{
    public TextMeshProUGUI p1Name;
    public TextMeshProUGUI p1HP;
    public TextMeshProUGUI p2Name;
    public TextMeshProUGUI p2HP;


    public string player1Name;
    public int player1HP;
    public string player2Name;
    public int player2HP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void Awake(){
        player1Name = GameHandler.EnterName.player1Name;
        player1HP = GameHandler.EnterName.playerHP;
        player2Name = GameHandler.EnterName.player2Name;
        player2HP = GameHandler.EnterName.playerHP;

        p1Name.text = player1Name;
        p1HP.text = player1HP + "";
        p2Name.text = player2Name;
        p2HP.text = player2HP + "";
    }

    public void StartGame()
    {
        SceneManager.LoadScene("EnterName");
        
    }

        public void PlayGame()
    {
        SceneManager.LoadScene("MainFight");
        
    }

}
