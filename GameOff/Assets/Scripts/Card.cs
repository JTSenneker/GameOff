using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType
{
    NULL,
    FIRE,
    ELEC,
    WATER,
    WOOD,
    HEAL
}

[CreateAssetMenu(fileName = "New Card")]
public class Card : ScriptableObject {

    public new string name;
    public string description;
    public string letterCode;
    public Sprite image;
    public int damage;
    public CardType cardType = CardType.NULL;
}
