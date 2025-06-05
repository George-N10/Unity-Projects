using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBarIM;
    public float CurrentHeath;
    private float MaxHealth = 250f;
    Player player;





    void Start()
    {
        healthBarIM = GetComponent<Image>();
        player = FindObjectOfType<Player>();

    }



    void Update()
    {
        CurrentHeath = player.HP;
        healthBarIM.fillAmount = CurrentHeath / MaxHealth;
        


    }
}
