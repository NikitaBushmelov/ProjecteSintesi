using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int health;
    public int damage;
    public float speed;

    public PlayerData(PlayerMovement player)
    {
        health = player.health;
        damage = player.daño;
        speed = player.speed;

    }
}
