using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDownJump : MonoBehaviour
{
    public float up = 0.5F;
    private float x, y, z;
    private MeshRenderer mr;
    private Transform ts;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        ts = GetComponent<Transform>();
        x = ts.position.x;
        y = ts.position.y;
        z = ts.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("click!");
        // leantweern
        ts.position = new Vector3(x,y + up,z);
    }
    private void OnMouseUp()
    {
        Debug.Log("exit");
        ts.position = new Vector3(x, y ,z);
    }
}
