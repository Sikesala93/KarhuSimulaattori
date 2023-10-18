using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Karhu : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int DecreaseHealth;

    public HealthBar healthBar;


    void Start()
    {
        healthBar.SetHealth(currentHealth);
        //InvokeRepeating("DecreaseHealth", 0, 2);

        //currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }



    float kulunutAika = 0;
    float aikajolloinnalkasyoyhdenpykalan = 1f;
    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKeyDown(KeyCode.Space))
        {
            EatMushroom(5);
        }*/


        kulunutAika += Time.deltaTime;
        if (kulunutAika > aikajolloinnalkasyoyhdenpykalan)
            {
            DecreasedHealth(1);
            kulunutAika = 0;
            }

        if (currentHealth < 1)
        {
            SceneManager.LoadScene(2);
        }

        if (currentHealth > 99)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void EatMushroom(int eat)
    {
        currentHealth += eat;

        healthBar.SetHealth(currentHealth);
    }

    public void EatPoisonMushroom(int eat)
    {
        currentHealth -= eat;

        healthBar.SetHealth(currentHealth);
    }

    void DecreasedHealth(int decreasedHealth)
    {
        currentHealth -= 1;
        int calculateHealth = currentHealth - decreasedHealth;
        healthBar.SetHealth(calculateHealth);
    }

    
}
