using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BasePawn : MonoBehaviour
{
    public string namePawn;
    public int hp;
    public int agility;
    public int endurance;
    public int strength;
    public Image imageHp;
    public TextMeshProUGUI agilityLabel;
    public TextMeshProUGUI enduranceLabel;
    public TextMeshProUGUI strengthLabel;
    public TextMeshProUGUI hpNumber;
    public TextMeshProUGUI damageToView;
    [HideInInspector]
    public int hpMax;

    private void Update()
    {
        imageHp.fillAmount = (float)hp / hpMax;
        
        hpNumber.text = hp.ToString();
    }

    protected void DrawValue()
    {
        agilityLabel.text = agility.ToString();
        enduranceLabel.text = endurance.ToString();
        strengthLabel.text = strength.ToString();
        hpNumber.text = hp.ToString();
    }
    public virtual int DealDamage()
    {
        return 0;
    }
}
