using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour
{
    public Material[] materials;
    public Material selected;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnMouseDown()
    {
        //if ()
       // {

        //}
        this.gameObject.GetComponent<MeshRenderer>().material = selected;
    }
}