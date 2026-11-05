namespace COMPSCI221
{
    public enum Day : byte 
    //enum - finite set of named constants
    //: byte - values are stored in bytes, must know how many enums you are using
    //DOES NOT have state, no fields, methods, constructors, etc.
    {
        Sunday, //First value starts at 0, increases by 1 per value
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}