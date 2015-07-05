using UnityEngine;
using System.Collections;

public class PlayerAttackCtroller : MonoBehaviour {

    private Animator playerAni;
    bool isCanAttackB;
	// Use this for initialization
	void Start () {
        playerAni = gameObject.GetComponent<Animator>();
        GameObject attackA = GameObject.Find("AttackNormal");
        GameObject attackRange = GameObject.Find("AttackRange");
        GameObject attackRed = GameObject.Find("AttackRed");
        UIEventListener.Get(attackA).onClick += PlayAttackA;
        UIEventListener.Get(attackRange).onClick += PlayAttackRange;
        UIEventListener.Get(attackRed).onClick += PlayAttackRed;
        attackRed.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayAttackA(GameObject go)
    {
   
        if (isCanAttackB && playerAni.GetCurrentAnimatorStateInfo(0).IsName("PlayerAttackA"))
        {
            Debug.Log("播放连招");

            //播放连招
            playerAni.SetTrigger("AttackB");
        }
        else
        {
            playerAni.SetTrigger("AttackA");
        }
        
    }
    public void PlayAttackRange(GameObject go)
    {
        playerAni.SetTrigger("AttackRange");

    }
    public void PlayAttackRed(GameObject go)
    {
        playerAni.SetTrigger("AttackA");

    }
    /// <summary>
    /// 连招播放的事件监听 在Animator中AttackA的动画中添加
    /// </summary>
    public void AttackBStart()
    {
        isCanAttackB = true;
    }
    public void AttacBEnd()
    {
        isCanAttackB = false;
    }
}
