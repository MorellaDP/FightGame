using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public static GameHandler EnterName;
    public TMP_InputField p1InputName;
    public TMP_InputField p2InputName;

    public TMP_InputField inputHP;

    //public TMP_Button healthNo;

    public string player1Name;
    public string player2Name;
    
    public int playerHP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        if (EnterName == null){
            EnterName = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void setName(){
        player1Name = p1InputName.text;
        player2Name = p2InputName.text;
        playerHP= System.Convert.ToInt32(inputHP.text);
    }

        public void changeScene(){
        StartCoroutine(delayPress());
    }

        public IEnumerator delayPress(){

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainFight");
    }




}
