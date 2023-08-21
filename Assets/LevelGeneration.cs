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
        transEnemies.ForEach(x =>
        {
            GameObject o = ObjectPooling.instance.GetObjectFromPool("Enemy");
            o.transform.position = x.position;
            o.GetComponent<EnemyData>().SetupEnemy(x.name + " set pos enemy");
            o.SetActive(true);
        });
    }
}
