using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTrans : MonoBehaviour
{
    public GameObject go;
    public Vector3 scaleChange, positionChange;
    private Vector3 temp;
    private bool IsFocous;
    // Start is called before the first frame update
    void Start()
    {
        //scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
        //positionChange = new Vector3(0.0f, -0.005f, 0.0f);
        temp = go.transform.position;

    }

    //void Update()
    //{
    //    ZoomIn();
    //    Right();
    //}

    public void StartFocous()
    {
        IsFocous = true;
    }
    public void StopFocous()
    {
        IsFocous = false;
    }

    public void ZoomIn()
    {
        if (IsFocous)
        {
            go.transform.localScale += scaleChange;
        }
        
    }
    public void ZoomOut()
    {   
        if(!IsFocous){
            return;
        }
        go.transform.localScale -= scaleChange;
    }
    public void Left()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.x -= positionChange.x;
        go.transform.position = temp;
    }
    public void Right()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.x += positionChange.x;
        go.transform.position = temp;
    }
    public void Up()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.y += positionChange.y;
        go.transform.position = temp;
    }
    public void Down()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.y -= positionChange.y;
        go.transform.position = temp;
    }
    public void Forward()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.z -= positionChange.z;
        go.transform.position = temp;
    }
    public void Backward()
    {
        if (!IsFocous)
        {
            return;
        }
        temp.z += positionChange.z;
        go.transform.position = temp;
    }
}