using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardNumber : MonoBehaviour {
    public Material[] materials;
    public card[] cards;
    public Vector3[] positions;
    public bool[] occupied;
    public int random;

    // Use this for initialization 
    void Start () {
        random = Random.Range(0, 3);
        this.gameObject.GetComponent<MeshRenderer>().material = materials[random];
        for (int i = 0; i < cards.Length-1; i++)
        {
            bool check = false;
            int rnd = Random.Range(0, 8);
           while (check == false)
            {
               

                if (occupied[rnd] == false)
                {
                    cards[i].transform.position = positions[rnd];
                    Debug.Log(positions[rnd]);
                    occupied[rnd] = !occupied[rnd];
                    check = !check;
                }
                else
                {
                    rnd = Random.Range(0, 8);
                }
            } 
          
            
            if (occupied[rnd] == false)
            {
                cards[i].transform.position = positions[rnd];
                Debug.Log(positions[rnd]);
                occupied[rnd] = !occupied[rnd];
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(Random.Range(0, 3));

    }
}
