using UnityEngine;
//здесь пока что только для убийства врага штука
public class EnemyKilled : MonoBehaviour
{
    public void EnemyKill()
    {
        Destroy(gameObject);
    }
}
