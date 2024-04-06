namespace Items.Weapons.Mounts
{
    public enum WeaponUsableMountState
    {
        Active,
        Disable
    }

    public interface IWeaponUsableMountController
    {
        void Set(WeaponUsableMountState state);
        void ToggleNext();
        void TogglePrev();
    }
}