namespace Actor.Controller
{
    public enum HumanActorPositionType
    {
        Lying,
        Sitting,
        Standing
    }

    public interface IHumanActorController : IActorController
    {
        /**
        * Метод для изменения позиции
        */
        void ChangePosition(HumanActorPositionType humanActorPositionType);

        /**
         * Использовать предмет находящийся в руках в направлении взгляда
         */
        void UseItemInHands();

        /**
         * Использовать особенность предмета в руках
         */
        void UseFeatureOfItemInHands();

        /**
         * Взять что-то в руки
         */
        void TakeInTheHands();

        /**
         * Выбросить предмет из рук
         */
        void ThrowFromHands();

        /**
        * Положить предмет в инвентарь
        */
        void PutInInventory();

        /**
         * Взять из инвентаря
         */
        void TakeFromInventory();

        /**
         * TODO: Использовать что либо (что имеет определенный интерфейс)
         */
        void Use();
    }
}