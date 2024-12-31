
using System;

public class BCA{

    public void Exams(){
        Console.WriteLine("Attending for 1st yr exams");
    }

    public void Attendence(){
        Console.WriteLine("Total 72 students");
    }

      public static void Main(string [] args){
        
        BCA khadeer=new BCA();
    //    BCA_Deg swaroopa =new BCA_Deg();

      swaroopa.Exams();
        swaroopa.Attendence();
        swaroopa.Exams();
    //    khadeer.pp();

    }
}

public class BCA_Deg : BCA{
       public void Exams(){
        Console.WriteLine("Attending for final yr exams");
    }


    public void pp(){
        Console.WriteLine("\n Pass percentage : 85% ");
    }
    
}