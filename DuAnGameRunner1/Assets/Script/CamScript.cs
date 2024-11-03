using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Di chuyển camera theo vị trí của người chơi cộng với offset
        transform.position = new Vector3(transform.position.x, transform.position.y, Player.transform.position.z - 14f);
    }
}
