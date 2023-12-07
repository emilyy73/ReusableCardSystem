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

    public bool hasBeenPlayed;
    public int handIndex;
    private GameManager gm;
    private int moveUp = 15;

    private void Start()
    {
        name = card.Name;
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

        gm = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        if (hasBeenPlayed == false)
        {
            transform.position += Vector3.up * moveUp;
            hasBeenPlayed = true;
            gm.availableCardSlots[handIndex] = true;
            Invoke("MoveToDiscardPile", 2f);
        }
    }

    void MoveToDiscardPile()
    {
        gm.discardPile.Add(this);
        this.gameObject.SetActive(false);
    }
}