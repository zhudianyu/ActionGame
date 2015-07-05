using UnityEngine;
using System.Collections;

public class JoyStick : MonoBehaviour {

	// Use this for initialization
    bool isPress = false;
    private Transform btn;

    public static float h;
    public static float v;
	void Start () {
        btn = transform.Find("Btn");
	}
	void OnPress(bool isPress)
    {
        this.isPress = isPress;
        if(isPress == false)
        {
            btn.localPosition = Vector3.zero;
            h = 0; v = 0;
        }

    }
	// Update is called once per frame
	void Update () {
	    if(isPress)
        {
       //左下角是原点  此处求btn的原点相对于父节点的
            Vector2 targetPos = UICamera.lastTouchPosition - new Vector2(91, 91);

            float distance = Vector2.Distance(Vector2.zero, targetPos);
            if(distance>73)
            {
                btn.localPosition = targetPos.normalized * 73;
            }
            else
            {
                btn.localPosition = targetPos;

            }
            h = targetPos.x / 73;
            v = targetPos.y / 73;
        }
	}
}
