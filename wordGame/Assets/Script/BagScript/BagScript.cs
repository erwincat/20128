using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Bag/New Bag")]
public class BagScript : ScriptableObject
{
    public List<ItemScript> itemList = new List<ItemScript>();
}
