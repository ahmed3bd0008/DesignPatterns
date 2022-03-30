using System;

namespace Singleton
{
    public class Calculate
    {
        private Calculate() { }
        public int Count { get; set; }
        //in start of programme will create instance of object until if not use instance
       // private static Calculate calculate=new Calculate() ;


        //only create instance when used it
        private static Calculate calculate=null ;
        public static Calculate  GetInstance(){
            if(calculate==null)
                    calculate=new Calculate();
            return calculate;
        }
        public void AddOne(){
            Count++;
        }
    }
}
