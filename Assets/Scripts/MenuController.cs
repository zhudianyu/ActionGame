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

    public Color[] colorArray;
    private int colorIndex = 0;
    void Start()
   {
       colorArray = new Color[] { Color.blue, Color.green, purple, Color.cyan, Color.red };
       DontDestroyOnLoad(this.gameObject);
    }
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
        colorIndex = 0;
        OnChangeColor(Color.blue);
    }
    public void OnColorGreen()
    {
        colorIndex = 1;
        OnChangeColor(Color.green);
    }
    public void OnColorPurple()
    {
        colorIndex = 2;
        OnChangeColor(purple);
    }
    public void OnColorCyan()
    {
        colorIndex = 3;
        OnChangeColor(Color.cyan);
    }
    public void OnColorRed()
    {
        colorIndex = 4;
        OnChangeColor(Color.red);
    }
    void OnChangeColor(Color c)
    {
        foreach(SkinnedMeshRenderer render in bodyMeshArray)
        {
            render.material.color = c;
        }
    }

    void Save()
    {
        PlayerPrefs.SetInt("headindex", headMeshIndex);
        PlayerPrefs.SetInt("handindex", handMeshIndex);
        PlayerPrefs.SetInt("colorindex", colorIndex);
    }
    public void OnPlay()
    {
        Save();
    }
}
