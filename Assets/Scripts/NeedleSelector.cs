using UnityEngine;

public class NeedleSelector : MonoBehaviour
{
    [SerializeField] GameObject inkParticle;

    public void ThreeNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.125f, .125f, .125f);
    }
    public void FiveNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.25f, .25f, .25f);
    }

    public void SevenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.375f, .375f, .375f);
    }

    public void ElevenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.5f, .5f, .5f);
    }

    public void FourteenNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.625f, .625f, .625f);
    }

    public void TwentyOneNeedle()
    {
        inkParticle.transform.localScale = new Vector3(.75f, .75f, .75f);
    }
}
