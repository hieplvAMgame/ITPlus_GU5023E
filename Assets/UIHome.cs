using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHome : MonoBehaviour
{
    public GameObject settingPanel;
    public Button settingButton;
    private void Awake()
    {
        settingButton.onClick.AddListener(()=>settingPanel.SetActive(true));
    }
}
