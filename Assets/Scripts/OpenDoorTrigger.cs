using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour
{
    [SerializeField] Animator doorAnimator;
    [SerializeField] Animator lampFlicker;
    [SerializeField] AudioSource doorSound;
    [SerializeField] AudioSource flicker;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pete"))
        {
            Invoke("FlickerSound", 0.6f); ;
            doorSound.Play();
            Debug.Log("Triggered");
            doorAnimator.SetBool("Opened", true);
            lampFlicker.SetBool("Flicker", true);
        }
        else return;

    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this);
    }

    private void FlickerSound()
    {
        flicker.Play();
    }
}
