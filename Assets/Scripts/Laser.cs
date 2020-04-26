

public sealed class Laser : Weapon, ICancelFire
{
    private Ammunition _tempAmmunition;

    public override void Fire()
    {
        if (!_isReady) return;
        var direction = -_barrel.right * transform.localScale.x;
        _tempAmmunition = Instantiate(_ammunition, _barrel.position, _barrel.rotation);
        _tempAmmunition.GetComponent<LaserAmmunitiom>().SetLineRenderer(_barrel, direction);
        _isReady = false;
    }

    public void EndFire()
    {
        _tempAmmunition.GetComponent<LaserAmmunitiom>().EndFire();
        _isReady = true;
    }
}