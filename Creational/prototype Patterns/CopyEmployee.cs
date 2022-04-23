namespace prototype_Patterns
{
    public class CopyEmployee : Employee
    {
        public override Employee deepCope()
        {
            Employee emp=new CopyEmployee(); 
            emp= (Employee)base.MemberwiseClone();
            emp.address=new Address(){
                BuilderNum=address.BuilderNum,
                City=address.City,
                Countery=address.Countery
            };
            return emp; 

        }

        public override Employee ShallowCope()
        {
            return (Employee) base.MemberwiseClone();
        }
    }
}