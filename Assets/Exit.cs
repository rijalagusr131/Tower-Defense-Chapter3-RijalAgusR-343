using UnityEngine;

public class Exit : MonoBehaviour
{
    public AudioSource ButtonSound;

    public void ExitGame()
    {
        AudioSource buttonsound = ButtonSound.GetComponent<AudioSource>();
        buttonsound.PlayOneShot(buttonsound.clip);
        Application.Quit ();
    }
}
