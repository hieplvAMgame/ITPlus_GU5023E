using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public int CurrentLevel
    {
        get
        {
            return PlayerPrefs.GetInt("A", 0);
        }
        set
        {
            PlayerPrefs.SetInt("A", value);
        }
    }
    public bool IsNewPlayer
    {
        get => PlayerPrefs.GetInt("IsNewPlayer", 1) == 1;
        set => PlayerPrefs.SetInt("IsNewPlayer", value ? 1 : 0);
    }
}
