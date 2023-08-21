using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data Level", menuName = "New Data Level")]
public class LevelDatasScripable : ScriptableObject
{
    public List<Vector3> listPosEnemies = new List<Vector3>();
}
