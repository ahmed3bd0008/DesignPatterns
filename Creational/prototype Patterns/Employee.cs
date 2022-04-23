namespace prototype_Patterns
{
    public abstract class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Address address { get; set; }

        public abstract Employee ShallowCope();
        public abstract Employee deepCope();
        public override string ToString()
        {
            return $@"
               Age:{Age}  
               name:{Name} 
               adress: {address.BuilderNum},{address.City},{address.Countery}
            ";
        }
    }
}