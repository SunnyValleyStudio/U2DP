using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponUI : MonoBehaviour
{
    [SerializeField]
    private Image weaponSprite;
    [SerializeField]
    private GameObject weaponSwapTip;

    public UnityEvent SwapWeaponEvent, ToggleWeaponTipUI;

    private void Start()
    {
        weaponSprite.enabled = false;
        weaponSprite.sprite = null;
        weaponSwapTip.SetActive(false);
    }

    public void SetWeaponImage(Sprite weaponSprite)
    {
        if (this.weaponSprite.sprite == weaponSprite)
            return;
        this.weaponSprite.enabled = true;
        this.weaponSprite.sprite = weaponSprite;
        SwapWeaponEvent?.Invoke();
    }

    public void ToggleWeaponTip(bool val)
    {
        this.weaponSwapTip.SetActive(val);
        if(val == true)
            ToggleWeaponTipUI?.Invoke();
    }
}
