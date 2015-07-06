using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnManager : MonoBehaviour {

    public EnemySpawn[] monsterArray;
    public EnemySpawn[] bossArray;
    public List<GameObject> enmeyList = new List<GameObject>();
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnEnemy());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator SpawnEnemy()
    {
        foreach (EnemySpawn enemy in monsterArray)
        {
            enmeyList.Add( enemy.Spawn());
        }
        if (enmeyList.Count > 0)
        {
            yield return new WaitForSeconds(0.2f);
        }

    }
}
