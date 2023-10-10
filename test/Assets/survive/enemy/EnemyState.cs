using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public int maxHp = 100;
    public int Hp = 100;

    public GameObject Item;
    GameObject Drop;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position;
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
            Drop = Instantiate(Item);
            Drop.transform.position = transform.position;
            Destroy(gameObject);
        }
        
    }
    public int HpMove
    {
        get { return Hp; }
        set { Hp = value; }
    }
}
