using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    private Transform player;
    public float speed = 2;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
  
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targePos = new Vector3(0, 3.3f, -2f) + player.position;
        transform.position = Vector3.Lerp(transform.position, targePos, speed * Time.deltaTime);
        Quaternion rot = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed * Time.deltaTime);
	}
}
