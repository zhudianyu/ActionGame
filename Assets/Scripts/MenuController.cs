using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    public Color purple;
    public SkinnedMeshRenderer headMeshRender;
    public Mesh[] headMeshArray;
    private int headMeshIndex = 0;


    public SkinnedMeshRenderer handMeshRender;
    public Mesh[] handMeshArray;
    private int handMeshIndex = 0;

    public SkinnedMeshRenderer[] bodyMeshArray;
    public void OnHeadMeshNext()
    {
        headMeshIndex++;
        headMeshIndex %= headMeshArray.Length;
        headMeshRender.sharedMesh = headMeshArray[headMeshIndex];

    }
    public void OnHandMeshNext()
    {
        handMeshIndex++;
        handMeshIndex %= headMeshArray.Length;
        handMeshRender.sharedMesh = handMeshArray[handMeshIndex];
    }
    public void OnColorBlue()
    {
        OnChangeColor(Color.blue);
    }
    public void OnColorGreen()
    {
        OnChangeColor(Color.green);
    }
    public void OnColorPurple()
    {
        OnChangeColor(purple);
    }
    public void OnColorCylan()
    {
        OnChangeColor(Color.cyan);
    }
    public void OnColorRed()
    {
        OnChangeColor(Color.red);
    }
    void OnChangeColor(Color c)
    {
        foreach(SkinnedMeshRenderer render in bodyMeshArray)
        {
            render.material.color = c;
        }
    }
    public void OnPlay()
    {

    }
}
