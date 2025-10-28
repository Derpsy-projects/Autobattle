using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class CoreScript : MonoBehaviour
{
    public static CoreScript instanse;
    public int charId;
    public List<CharacterClass> playerClassList;
    public List<EnemyClassDesc> enemyList;
    private CharacterClass currentPlayerClass;
    public EnemyClassDesc currentEnemy;
    public PlayerPawn player;
    public EnemyPawn enemy;
    public GameObject levelUp;
    public GameObject weaponLoot;
    public GameObject lastScreen;
    public GameObject winScreen;
    public TextMeshProUGUI gameLog;
    
    int enemiesDefeated = 0;

    private bool battleActive = false;
    private bool playerTurn = true;
    private void Start()
    {
        levelUp.SetActive(true);



        DontDestroyOnLoad(gameObject);
        instanse = this;



        if (player.agility >= enemy.agility)
        {
            playerTurn = true;

        }
        else
        {
            playerTurn = false;

        }

    }
    IEnumerator BattleLoop()
    {
        battleActive = true;
        currentEnemy = enemyList[Random.Range(0, enemyList.Count)];
        enemy.SetUpEnemy(currentEnemy);

        while (battleActive)
        {
            yield return new WaitForSeconds(2f); // 1 удар в  2 секунды

            if (playerTurn)
            {
                Attack(player, enemy);
            }
            else
            {
                Attack(enemy, player);
            }

            playerTurn = !playerTurn; // Меняем очередь
        }
        if (player.hp > 0)
        {


            weaponLoot.SetActive(true);
            enemiesDefeated++;

            Debug.Log("Побеждено врагов: " + enemiesDefeated);

            
                levelUp.SetActive(true);
           
            
            if (enemiesDefeated == 5)
            {
                winScreen.SetActive(true);
            }
        }
        else
        {
            lastScreen.SetActive(true);
        }

    }

    public void SelectWarior()
    {
        currentPlayerClass = playerClassList[0];
        player.SetUp(currentPlayerClass);
        levelUp.SetActive(false);
        StartCoroutine(BattleLoop());
    }

    public void SelectRogue()
    {
        currentPlayerClass = playerClassList[1];
        player.SetUp(currentPlayerClass);
        levelUp.SetActive(false);
        StartCoroutine(BattleLoop());
    }

    public void SelectBarbarian()
    {
        currentPlayerClass = playerClassList[2];
        player.SetUp(currentPlayerClass);
        levelUp.SetActive(false);
        StartCoroutine(BattleLoop());
    }
    void Attack(BasePawn attacker, BasePawn target)
    {

        int damage = attacker.DealDamage();
        target.hp -= damage;

        Debug.Log($"{attacker.namePawn} наносит {damage} урона {target.namePawn}. Осталось HP: {target.hp}");
        gameLog.text = ($"{attacker.namePawn} наносит {damage} урона {target.namePawn}. Осталось HP: {target.hp}");
        
        if (target.hp <= 0)
        {
            battleActive = false;
            Debug.Log($"{target.namePawn} погиб! Бой окончен.");
            gameLog.text = ($"{target.namePawn} погиб! Бой окончен.");
        }



    }

}

