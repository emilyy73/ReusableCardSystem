using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    [SerializeField] GameObject cardName;
    [SerializeField] GameObject cardImage;
    [SerializeField] GameObject cardDescription;
    [SerializeField] GameObject cardAttack;
    [SerializeField] GameObject cardHealth;
    [SerializeField] GameObject cardCost;

    private new string name;
    private string description;
    private int attack;
    private int health;
    private int cost;

    private TMP_Text nameObject;
    private TMP_Text descriptionObject;
    private TMP_Text attackObject;
    private TMP_Text healthObject;
    private TMP_Text costObject;

    private void Start()
    {
        name = card.name;
        description = card.Description;
        attack = card.Attack;
        health = card.Health;
        cost = card.Cost;

        nameObject = cardName.GetComponent<TMP_Text>();
        descriptionObject = cardDescription.GetComponent<TMP_Text>();
        attackObject = cardAttack.GetComponent<TMP_Text>();
        healthObject = cardHealth.GetComponent<TMP_Text>();
        costObject = cardCost.GetComponent<TMP_Text>();

        nameObject.text = name;
        descriptionObject.text = description;
        attackObject.text = "ATK: " + attack.ToString();
        healthObject.text = "HP: " + health.ToString();
        costObject.text = cost.ToString();
    }
}