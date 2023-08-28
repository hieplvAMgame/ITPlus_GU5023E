using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public List<Transform> transEnemies = new List<Transform>();
    public List<LevelDatasScripable> listLevel = new List<LevelDatasScripable>();
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void GenerateLevel()
    {
        // check level nao
        listLevel[0].listPosEnemies.ForEach(x =>
        {
            GameObject o = ObjectPooling.instance.GetObjectFromPool("Enemy");
            o.transform.position = x;
            o.GetComponent<EnemyData>().Setup();
            o.SetActive(true);
        });
    }
}
