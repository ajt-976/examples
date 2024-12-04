namespace FarmSystem.Interfaces.Animals
{
    /// <summary>
    /// Interface for milkable animals which exposes method to produce milk
    /// </summary>
    public interface IMilkableAnimal
    {
        #region  Public Methods
        void ProduceMilk();

        #endregion
    }
}