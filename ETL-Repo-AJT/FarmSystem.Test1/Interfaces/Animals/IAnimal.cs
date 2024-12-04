namespace FarmSystem.Interfaces.Animals
{
    /// <summary>
    /// Interface for all Animals - includes common properties and methods
    /// </summary>
    public interface IAnimal
    {
        #region Properties
        string Id { get; set; }
        string Name { get; }
        int NoOfLegs { get; set; }
        string Sound { get; set; }

        #endregion

        #region Public Methods
        void Talk();
        void Walk();
        void Run();
        void Release();

        #endregion
    }
}
