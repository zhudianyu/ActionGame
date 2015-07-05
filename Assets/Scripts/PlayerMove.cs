using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    private CharacterController cc;
    public float moveSpeed = 4;
    private Animator playerAnimator;
    void Awake()
    {
        cc = this.gameObject.GetComponent<CharacterController>();
        playerAnimator = gameObject.GetComponent<Animator>();

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if(JoyStick.h != 0 || JoyStick.v != 0)
        {
            h = JoyStick.h;
            v = JoyStick.v;
        }
        if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1f)
        {
            playerAnimator.SetBool("Walk", true);
            if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("PlayerRun"))
            {
                Vector3 targetPos = new Vector3(h, 0, v);
                //人物的朝向
                transform.LookAt(targetPos + transform.position);
                
                cc.SimpleMove(transform.forward * moveSpeed);
            }
        }
        else
        {
            playerAnimator.SetBool("Walk", false);
        }
	}
}
