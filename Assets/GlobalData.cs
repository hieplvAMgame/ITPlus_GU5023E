using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public bool IsSoundOn
    {
        get => PlayerPrefs.GetInt("IsSoundOn", 1) == 1;
        set => PlayerPrefs.SetInt("IsSoundOn", value ? 1 : 0);
    }
    public bool IsVibrate
    {
        get => PlayerPrefs.GetInt("IsVibrate", 1) == 1;
        set => PlayerPrefs.SetInt("IsVibrate", value ? 1 : 0);
    }
}
