using UnityEngine;

public class CollectCube : MonoBehaviour
{
    public AudioSource collectFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (collectFX != null)
                collectFX.Play();

            MasterInfo.coinCount++;
            Destroy(gameObject); // remove cube after collecting
        }
    }
}
