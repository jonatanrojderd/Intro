namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Common Value Types (Primitive Types) used in .NET
             */
            int @int;
            float @float;
            double @double;
            bool @bool;
            char @char;
            
            // Using the created enum as an example.
            VehicleType vehicleType;
            
            // Reference Types (Non-Primitive Types)
            string @string;
            int[] array;
            
            // Using the created class as an example.
            Vehicle vehicle;

            
            // Hello branch
        }
    }
    
    /* Classes is used everywhere in a .NET application,
     * they can be seen as a container of Data and Logic.
     * Classes is a Reference Type, which means that the variable created is NULL
     * until you explicitly create an object and assign it.
     * i.e. Vehicle myVehicle = new Vehicle(); (or assign an already created object).
     */
    public class Vehicle
    {
        // This is a private field, this can only be accessed in the Vehicle class.
        private VehicleType _type;
        
        /* This is a Constructor.
         * It gets called when an object is created.
         */
        public Vehicle(VehicleType type)
        {
            _type = type;
        }

        /* A Method (also called function) contains logic that gets processed when called.
         * It could be used to process some data that gets passed into it through parameters,
         * or return data. 
         */
        public VehicleType GetVehicleType()
        {
            return _type;
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