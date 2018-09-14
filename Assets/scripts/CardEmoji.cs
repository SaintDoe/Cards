using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEmoji : MonoBehaviour {
    public Material[] materials;
    public int random;
    // Use this for initialization 
    void Start () {
        random=Random.Range(0, 3);
        this.gameObject.GetComponent<MeshRenderer>().material = materials[random];

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Random.Range(0, 3));

    }
}
