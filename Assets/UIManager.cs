using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour, IGameSubcriber
{
    public GameObject gameWinObj;
    public GameObject gameLoseObj;

    public void GameLose()
    {
        gameLoseObj.SetActive(true);
    }

    public void GamePause()
    {
    }

    public void GamePrepare()
    {
        gameLoseObj.SetActive(false);
        gameWinObj.SetActive(false);
    }

    public void GameResume()
    {
    }

    public void GameStart()
    {

    }

    public void GameWin()
    {
        gameWinObj.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.AddSubcriber(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
