using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Game game = new Game();

        game.AddEnemy(new Enemy(EnemyType.Melee));
        game.AddEnemy(new Enemy(EnemyType.Range));
        game.AddEnemy(new Enemy(EnemyType.Magic));
        game.AddEnemy(new Enemy(EnemyType.Tank));

        int totalHP = game.CalculateTotalHP();

        Debug.Log("Total Hp of enemy Army:" + totalHP);
    }
}
