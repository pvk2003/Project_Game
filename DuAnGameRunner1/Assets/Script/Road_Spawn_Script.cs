using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Spawn_Script : MonoBehaviour
{
    public static Road_Spawn_Script instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Đảm bảo chỉ có một instance duy nhất
        }
    }
    [SerializeField] GameObject Road_Tile;
    [SerializeField] Transform spawn_pos;

    void Start()
    {
        
    }


    public void Spawn_Road()
    {
        Instantiate(Road_Tile, spawn_pos.position, Quaternion.identity);
        spawn_pos.position = new Vector3(spawn_pos.position.x, spawn_pos.position.y, spawn_pos.position.z + 58f);
    }

    private void OnDestroy(){
        Destroy(instance);
    }
}
