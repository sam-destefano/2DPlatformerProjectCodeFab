using UnityEngine;

public class BallSpawnPoint : MonoBehaviour
{
    public void SetAsSpawnPoint()
    {
        CompanionBallScript.instance.SetSpawnPoint(transform);
    }
}
