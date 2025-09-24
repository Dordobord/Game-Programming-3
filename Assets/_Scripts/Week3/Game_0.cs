using System.Collections.Generic;
using UnityEngine;

public class Game_0 : MonoBehaviour
{
    private List<Enemy_0> enemies = new List<Enemy_0>();
    public void AddEnemy(Enemy_0 enemy)
    {
        enemies.Add(enemy);
    }

    public int CalculateTotalHP()
    {
        int total = 0;
        foreach (var enemy in enemies)
        {
            total += enemy.CalculateDamage(); //communicate from Game to Enemy
        }
        return total;
    }
}
