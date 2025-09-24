using UnityEngine;

public enum EnemyType
{
    Range,
    Melee,
    Magic,
    Tank
}
public class Enemy : MonoBehaviour
{
    public EnemyType enemyType;

    //constructor - when creating an enemy, specify its type
    public Enemy(EnemyType type)
    {
        this.enemyType = type;
    }

    public int CalculateEnemyHP()
    {
        switch (enemyType)
        {
            case EnemyType.Range:
                return 5;
            case EnemyType.Melee:
                return 10;
            case EnemyType.Magic:
                return 7;
            case EnemyType.Tank:
                return 20;
            default:
                return 0;
        }
    }
}
