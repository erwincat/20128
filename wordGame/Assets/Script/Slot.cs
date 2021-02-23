using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public ItemScript slotItem;
    public UnityEngine.UI.Image slotImage;
    public UnityEngine.UI.Text slotNumber;

    public void ItemOnClicked() {
        BagMannager.UpdateItemInfo(slotItem.ItemInfo);
    }
}
