using UnityEngine;

public class GameManager_0 : MonoBehaviour
{
    void Start()
    {
        Game_0 game = new Game_0();

        game.AddEnemy(new Tank());
        int totalHP = game.CalculateTotalHP();

        Debug.Log("Total Hp of enemy Army:" + totalHP);
    }
}
