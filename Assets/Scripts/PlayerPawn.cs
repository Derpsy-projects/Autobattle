using UnityEngine;
using UnityEngine.UI;

public class PlayerPawn : BasePawn
{
    public WeaponClass currentWeapon;
    private int damageToText;
    public RawImage weaponPlayerImage;
    public override int DealDamage()
    {
        return currentWeapon.damage + strength;
        

    }
    public void GetNewWeapon(WeaponClass newWeapon)
    {
        currentWeapon = newWeapon;
        weaponPlayerImage.texture = currentWeapon.weaponIcon;
    }
    

    private void Start()
    {
        agility = Random.Range(1, 3);
        endurance = Random.Range(1, 3);
        strength = Random.Range(1, 3);
        


        DrawValue();
    }
    public void SetUp(CharacterClass currentClass)
    {
        hpMax = hpMax + currentClass.health;
        hp = hpMax;
        hpNumber.text = hp.ToString();
        namePawn = currentClass.Name;


        if (currentWeapon == null)
        {
            GetNewWeapon(currentClass.currentWeapon) ;

        }

        if (currentWeapon != null)
        {
            damageToText = currentWeapon.damage + strength;
            damageToView.text = damageToText.ToString();

        }
        else
        {
            Debug.LogWarning("Оружие не назначено для игрока!");
        }
    }

}
