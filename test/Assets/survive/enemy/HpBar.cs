using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    Slider hpSlider;

    EnemyState ene;

    GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        hpSlider = this.GetComponent<Slider>();
        ene= GetComponentInParent<EnemyState>();
        hpSlider.maxValue = ene.maxHp;
        
        hpSlider.value = ene.maxHp;

        canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        //�e�I�u�W�F�N�g�̉�]�̉e�����󂯂Ȃ��悤��
        this.transform.LookAt(canvas.transform);

        hpSlider.value = ene.Hp;
    }
}
