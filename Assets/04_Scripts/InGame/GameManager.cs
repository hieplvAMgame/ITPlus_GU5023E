using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour,IGameSubcriber
{
    public static GameManager instance;
    public GAME_STATE state;
    #region GameState Method
    public void GameLose()
    {
        listSubcriber.ForEach(x => x.GameLose());
    }

    public void GamePause()
    {
        listSubcriber.ForEach(x => x.GamePause());
    }

    public void GamePrepare()
    {
        Debug.Log("Call Prepare");
        listSubcriber.ForEach(x => x.GamePrepare());
    }

    public void GameResume()
    {
        listSubcriber.ForEach(x => x.GameResume());
    }

    public void GameStart()
    {
        Debug.Log("Call Start");
        listSubcriber.ForEach(x => x.GameStart());
    }

    public void GameWin()
    {
        listSubcriber.ForEach(x => x.GameWin());
    }
    #endregion
    private List<IGameSubcriber> listSubcriber = new List<IGameSubcriber>();

    public void AddSubcriber(IGameSubcriber sub)
    {
        listSubcriber.Add(sub);
    }
    public void RemoveSubcriber(IGameSubcriber sub)
    {
        listSubcriber.Remove(sub);
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Check()
    {
        switch (state)
        {
            case GAME_STATE.GameStart:
                GameStart();
                break;
            case GAME_STATE.GamePrepare:
                GamePrepare();
                break;
        }
    }
}
