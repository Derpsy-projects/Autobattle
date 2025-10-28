using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Scriptable Objects/WeaponClass")]
public class WeaponClass : ScriptableObject
{
    public string Name;
    public int damage;
    public enum DamageType { piercing, chopping, crushing };
    public DamageType typeDamage;
    public Texture weaponIcon;
}
