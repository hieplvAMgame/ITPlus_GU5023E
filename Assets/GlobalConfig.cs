using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalConfig : MonoBehaviour
{
    private void Awake()
    {
        SceneLoader.Instance.LoadScene("Level1", ()=>GameManager.Instance.GamePrepare());
    }
}
