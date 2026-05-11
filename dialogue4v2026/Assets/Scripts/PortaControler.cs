using UnityEngine;

public class PortaControler : MonoBehaviour
{
    public Animation anim;
    private bool isOpen;

    private void OpenClose()
    {
        if (isOpen)
        {
            anim.Play();
        }
    }
}
