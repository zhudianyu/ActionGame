using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

    public GameObject prefab;

    public GameObject Spawn()
    {
        return GameObject.Instantiate(prefab) as GameObject;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
