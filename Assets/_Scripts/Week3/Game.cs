using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public List<Enemy> enemies = new();
    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public int CalculateTotalHP()
    {
        int total = 0;
        foreach (var enemy in enemies)
        {
            total += enemy.CalculateEnemyHP(); //communicate from Game to Enemy
        }
        return total;
    }
}
