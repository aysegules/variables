internal class Program
{
    public static void Main(string[] args)
    {
        byte b =5;               //1 byte
        sbyte s = 5;             //1 byte
           
        short s1=5;              //2 byte
        ushort us=5;             //2 byte
        
        Int16 i16=2;             //2 byte
        int i=2;                 //4 byte
        Int32 i32=2;             //4 byte
        Int64 i64=2;             //8 byte
        
        uint ui=2;               //4 byte
        long l=4;                //8 byte
        ulong ul=4;              //8 byte
         
        //Reel sayılar          
        float f=5;               //4 byte
        double d=5;              //8 byte
        decimal de=5;            //16 byte
           
        char c='2';              //2 byte
        string str="aysegul";    //sınırsız
           
        bool b1=true;            //1 byte
        bool b2=false;           //1 byte

        DateTime dt=DateTime.Now;
        Console.WriteLine(dt);

        object o1="x";
        object o2='y';
        object o3=4;
        object o4=4.3;

        //String ifadeler
        string str1=null;           //string.Empty
        string ad="aysegul";
        string soyad="eski";
        string fullName=ad+" "+soyad;

        //Integer tanımlama sekilleri
        int integer1=5;
        int integer2= 3;
        int integer3=integer1+integer2;

        //Bollean
        bool bool1=10>2;

        //Degisken donusumleri
        string str2="20";
        int int1=20;

        string yeniDeger= str2 + int1.ToString();

        Console.WriteLine(yeniDeger);

        int int2=int1+ Convert.ToInt32(str2);
        Console.WriteLine(int2);

        int int3=int1 + int.Parse(str2);
        Console.WriteLine(int3);

        //DateTime 
        string datetime=DateTime.Now.ToString("dd.mm.yyyy");
        Console.WriteLine(datetime);

        string datetime1=DateTime.Now.ToString("dd/mm/yyyy");
        Console.WriteLine(datetime1);

        string hour=DateTime.Now.ToString("hh.mm");
        Console.WriteLine(hour);
    }
}