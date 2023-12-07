using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    [SerializeField] private new string name;
    [SerializeField] private string description;

    [SerializeField] private Sprite artwork;

    [SerializeField] private int cost;
    [SerializeField] private int attack;
    [SerializeField] private int health;

    // pubic getters

    public string Name => name;
    public string Description => description;
    public int Cost => cost;
    public int Attack => attack;
    public int Health => health;
}
