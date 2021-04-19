using UnityEngine;

public class NeedleSelector : MonoBehaviour
{
    public GameObject inkParticle;
    [SerializeField] MachineCrosshair crosshair;

    private void Start()
    {
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }

    public void ThreeNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.125f, .125f, .125f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }
    public void FiveNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.25f, .25f, .25f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }

    public void SevenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.375f, .375f, .375f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }

    public void ElevenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.5f, .5f, .5f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }

    public void FourteenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.625f, .625f, .625f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }

    public void TwentyOneNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.75f, .75f, .75f);
        crosshair.transform.localScale = inkParticle.transform.localScale;
    }
}
