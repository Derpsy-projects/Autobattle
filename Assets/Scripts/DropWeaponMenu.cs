using UnityEngine;
using UnityEngine.UI;

public class DropWeaponMenu : MonoBehaviour
{
    public RawImage oldIconWeapon;
    public RawImage newIconWeapon;
    

    public void SetNewWeapon()
    {
        CoreScript.instanse.player.GetNewWeapon(CoreScript.instanse.currentEnemy.lootReward);
        gameObject.SetActive(false);
    }
    public void SkipWeapon()
    {
        gameObject.SetActive (false);
    }

    private void OnEnable()
    {
        oldIconWeapon.texture = CoreScript.instanse.player.currentWeapon.weaponIcon;
        newIconWeapon.texture = CoreScript.instanse.currentEnemy.lootReward.weaponIcon;
    }
}
