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
        public abstract VehicleType GetVehicleType();
    }

    public class Car : Vehicle
    {
        /* A Method (also called function) contains logic that gets processed when called.
         * It could be used to process some data that gets passed into it through parameters,
         * or return data. 
         */
        public override VehicleType GetVehicleType()
        {
            return VehicleType.Car;
        }
    }
}
