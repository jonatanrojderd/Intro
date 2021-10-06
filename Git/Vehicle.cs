namespace Git
{
    
    /* Classes is used everywhere in a .NET application,
     * they can be seen as a container of Data and Logic.
     * Classes is a Reference Type, which means that the variable created is NULL
     * until you explicitly create an object and assign it.
     * i.e. Vehicle myVehicle = new Vehicle(); (or assign an already created object).
     */
    public abstract class Vehicle
    {
        // This is a private field, this can only be accessed in the Vehicle class.
        // private VehicleType _type;
        
        /* This is a Constructor.
         * It gets called when an object is created.
         */
        // public Vehicle(VehicleType type)
        // {
        //     _type = type;
        // }

        /* A Method (also called function) contains logic that gets processed when called.
         * It could be used to process some data that gets passed into it through parameters,
         * or return data. 
         */
        public abstract VehicleType GetVehicleType();
        // {
        //     return _type;
        // }
    }

    public class Car : Vehicle
    {
        // public Car(VehicleType type)
        //  : base(type)
        // {
        // }

        public override VehicleType GetVehicleType()
        {
            return VehicleType.Car;
        }
    }

    /* Enums is a Value Type that contains Constants.
     * This enum stores different types of Vehicles, the standard enum is like an int.
     */
    public enum VehicleType
    {
        None = 0,
        Car = 1,
        Motorcycle = 2,
        Truck = 3
    }
}
