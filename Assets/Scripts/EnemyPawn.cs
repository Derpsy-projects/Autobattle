using UnityEngine;

public class EnemyPawn : BasePawn
{
    public int damage;
    public override int DealDamage()
    {
        return damage;
    }
    public void SetUpEnemy(EnemyClassDesc currentEnemy)
    {
        agility = currentEnemy.agility;
        endurance = currentEnemy.endurance;
        strength = currentEnemy.strength;
        damage = currentEnemy.damage;
        hp = currentEnemy.health;
        namePawn = currentEnemy.Name;
        hpMax = hp;
        DrawValue();
    }
}
