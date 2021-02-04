using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Bag/New Item")]
public class ItemScript : ScriptableObject
{
    public string ItemName;
    public Sprite ItemICon;
    public int ItemNumber;
    [TextArea]
    public string ItemInfo;

    public bool isCuandai;//是否可装备
}
