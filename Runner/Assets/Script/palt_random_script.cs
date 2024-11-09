using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palt_random_script : MonoBehaviour
{
    public GameObject[] difficults;
    // Start is called before the first frame update
    void Start()
    {
        int random_value = Random.Range(0, difficults.Length);

        difficults[random_value].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
