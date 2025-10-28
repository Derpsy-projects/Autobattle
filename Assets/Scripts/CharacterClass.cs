using UnityEngine;

[CreateAssetMenu(fileName = "CharaterClass", menuName = "Scriptable Objects/CharaterClass")]
public class CharacterClass : ScriptableObject
{
    public string Name;
    public int agility;
    public int strength;
    public int endurance;
    public int health;
    public WeaponClass currentWeapon;
}
