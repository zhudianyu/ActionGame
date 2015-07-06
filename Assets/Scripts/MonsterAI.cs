using UnityEngine;
using System.Collections;

public class MonsterAI : MonoBehaviour {

    private Transform playerTans;
    private Animator playerAnimator;
    public float attackDistance = 1.0f;//Monster攻击距离
    private CharacterController cc;
    public float bossSpeed = 3;
    public float attackTime = 2f;//Monster攻击频率
    public float bossTimer = 0;//Monster攻击定时器
	// Use this for initialization
	void Start () {
        playerTans = GameObject.FindGameObjectWithTag("Player").transform;
        playerAnimator = this.gameObject.GetComponent<Animator>();
        cc = this.GetComponent<CharacterController>();
        bossTimer = attackTime;
	}
	
	// Update is called once per frame
	void Update () {
        //boss朝向角色
        Vector3 targetPos = playerTans.position;
        targetPos.y = transform.position.y;
        transform.LookAt(playerTans.position);
        float distance = Vector3.Distance(targetPos, transform.position);
        if (distance > attackDistance)
        {
            bossTimer = attackTime;//追上之后马上攻击
            if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("MonRun"))
            {
                cc.SimpleMove(transform.forward * bossSpeed);
            }
            playerAnimator.SetBool("isWalk", true);

          
        }
        else
        {
            bossTimer += Time.deltaTime;
            if (bossTimer >= attackTime)
            {
                bossTimer = 0;
                playerAnimator.SetTrigger("Attack");
            }
            else
            {
                playerAnimator.SetBool("isWalk", false);
            }
        }
	
	}
}
