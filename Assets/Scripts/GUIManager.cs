using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {


    public GUIText gameOverText, instructionsText, IntroText, HealthInfo, PowerupInfo;



    void Start()
    {
        StartGame.GameStart += GameStart;
        gameOverText.enabled = false;
        StartGame.GameOver += GameOver;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        { StartGame.TriggerGameStart(); }
    
    
    }

    private void GameStart()
    {
    gameOverText.enabled= false;
    instructionsText.enabled = false;
        IntroText.enabled = false;
        enabled = false;

    
    }
    private void GameOver()
    {
        gameOverText.enabled = true;
        instructionsText.enabled = true;
        enabled = true;
    
    }


}
