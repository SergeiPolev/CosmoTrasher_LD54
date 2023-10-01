using DG.Tweening;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private void Start()
    {
        GetComponent<CanvasGroup>().DOFade(0, 1f).SetDelay(30);
    }
}