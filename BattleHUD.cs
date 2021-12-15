using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleHUD : MonoBehaviour
{
    //Stats
    public Text atk;
    public Text def;
    public Text wis;
    public Text spd;
    public Text res;

    //Posible units
    public GameObject enemy;
    public GameObject player;

    Unit enemyUnit;
    Unit playerUnit;

    //Health and mana pools
    public Slider hpSlider;
    public Slider mpSlider;
    public Slider enemyhpSlider;

    //Player stats
    int attack = 15;
    int mana = 100;
    int defense = 5;
    int hp = 100;

    int turn = 1;

    //Enemy stats
    int enemyHp = 100;
    int enemyAtk = 22;
    int enemyDef = 8;

    public void attackComand() 
    {
        //PlayerTurn
        enemyhpSlider.value = enemyHp - (attack - (enemyDef / 2));
        enemyHp = (int)enemyhpSlider.value;
        mpSlider.value = mana - 6; //Spend 6 mana
        mana = (int)mpSlider.value;
        attack = 15;

        //EnemyTurn
        if (turn == 3)
        {
            hpSlider.value = hp - (enemyAtk * 2 - (defense / 2));
            turn = 0;
        }

        else
        {
            hpSlider.value = hp - (enemyAtk - (defense / 2));
        }
        hp = (int)hpSlider.value;
        turn++;
        victory();
    }

    public void healandBuff() 
    {
        //PlayerTurn
        hpSlider.value = hp + 70; //Heal 70 HP
        mpSlider.value = mana - 50; //Spend 50 mana points

        if (attack == 15) 
        {
            attack = attack * 3; //Triple attack if buff not applied
        }
        hp = (int)hpSlider.value;
        mana = (int)mpSlider.value;

        //EnemyTurn
        if (turn == 3)
        {
            hpSlider.value = hp - (enemyAtk * 2 - (defense / 2));
            turn = 0;
        }
        else 
        {
            hpSlider.value = hp - (enemyAtk - (defense / 2));
        }
        hp = (int)hpSlider.value;
        turn++;
        victory();
    }

    public void defend() 
    {
        //Player Turn
        defense = (defense * 8);
        mpSlider.value = mana - 15; //Spend 20 mana points

        //EnemyTurn
        if (turn == 3)
        {
            hpSlider.value = hp - (enemyAtk * 2 - (defense / 2));
            enemyhpSlider.value = enemyHp - ((enemyAtk * 2) /2 - (enemyDef / 2)); //Return half the damage

            enemyHp = (int)enemyhpSlider.value;
            turn = 0;
        }

        else
        {
            hpSlider.value = hp - (enemyAtk - (defense / 2));
            enemyhpSlider.value = enemyHp - ((enemyAtk * 1) / 2 - (enemyDef / 2)); //Return half the damage

            enemyHp = (int)enemyhpSlider.value;
        }
        mana = (int)mpSlider.value;
        hp = (int)hpSlider.value;
        turn++;

        defense = 5;
        victory();
    }
    
    //Scratched content future working planned.
    public void setHud() 
    {
        atk.text = "Atk: " + 10;
        def.text = "Def: " + 8;
        spd.text = "Spd: " + 15;
        wis.text = "Wisdom: " + 15;
        res.text = "Resist: " + 10;
    }

    //victory codition
    public void victory() 
    {
        if ((hp >= 1 && mana >= 1) && enemyHp <= 0) 
        {
            SceneManager.LoadScene("Victory");
        }

        if (mana <= 0 || hp <= 0) 
        {
            SceneManager.LoadScene("Game Over");
        }
    }   

}
