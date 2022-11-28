using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DeathPlaneController : MonoBehaviour
{
    public Transform currentCheckPoint;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            var player = other.gameObject.GetComponent<PlayerBehaviour>();
            player.life.LoseLife();
            player.health.ResetHealth();

            if (player.life.value > 0)
            {
                ReSpawn(other.gameObject);

                FindObjectOfType<SoundManager>().PlaySoundFX(Sound.DEATH, Channel.PLAYER_DEATH_FX);
            }
            
        }
    }

    public void ReSpawn(GameObject go)
    {
        go.transform.position = currentCheckPoint.position;
    }
}
