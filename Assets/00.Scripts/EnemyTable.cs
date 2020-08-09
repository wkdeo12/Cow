using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyName { Cow, Tiger, Shark, Dear, Chicken, Octo, Sclopion, Cube }

public class EnemyTable : MonoBehaviour
{
    public List<GameObject> enemyPrefablist;

    public Dictionary<string, List<GameObject>> enemyDictionary;

    public EnemyName selectedEnemy = EnemyName.Cow;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpwanEnemy(selectedEnemy);
        }
    }

    private void Awake()
    {
        enemyDictionary = new Dictionary<string, List<GameObject>>();
    }

    public void SpwanEnemy(EnemyName name)
    {
        string e_name = name.ToString();
        var enemyInlist = enemyPrefablist[(int)name];
        var go = GameObject.Instantiate(enemyInlist, transform);
        if (enemyDictionary.ContainsKey(e_name))
        {
            enemyDictionary[e_name].Add(go);
        }
        else
        {
            enemyDictionary.Add(e_name, new List<GameObject>());
            enemyDictionary[e_name].Add(go);
        }
    }
}