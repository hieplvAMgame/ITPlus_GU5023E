using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalConfig : MonoBehaviour
{
    private void Awake()
    {
        SceneLoader.Instance.LoadScene(1);
    }
}
