using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    Slider hpSlider;

   

    EnemyState ene;

    int EneHp=100;
    // Start is called before the first frame update
    void Start()
    {

         
        hpSlider = this.GetComponent<Slider>();
        ene= GetComponentInParent<EnemyState>();
        hpSlider.maxValue = ene.maxHp;
        
        hpSlider.value = ene.maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
        hpSlider.value = ene.Hp;
    }
}
