using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveColor : MonoBehaviour
{
    public Color hightlightcolor = Color.yellow;
    private Color startcolor;
    private MeshRenderer mr;
    void Start()
    {
        //获取初始颜色
        mr = GetComponent<MeshRenderer>();
        startcolor = mr.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        Debug.Log("here it is!");
        mr.material.color = hightlightcolor;
    }

    private void OnMouseExit()
    {
        Debug.Log("gone");
        mr.material.color = startcolor;
    }
}
