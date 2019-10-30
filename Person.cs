namespace Encapulation
{
   public class Person
    {
        private string fname;
        private string lname;
        private int age;
        private double height;
        private double weight;


        //public string  Fname   // the FName property
        //{
        //    get => fname;
        //    set => fname = value;
        //}
        //public string Lname   // the LName property
        //{
        //    get => lname;
        //    set => lname = value;
        //}

        //public int  Age   // the Name property
        //{
        //    get => age;
        //    set => age = value;
        //}
        //public double Height   // the Name property
        //{
        //    get => height;
        //    set => height = value;
        //}
        //public double Weight   // the Name property
        //{
        //    get => weight;
        //    set => weight = value;
        //}




        public string getfname() { return fname; }
        public void setfname(string Fname) { fname = Fname; }
        public string getlname() { return lname; }
        public void setlname(string Lname) { lname = Lname; }
        public int getage() { return age; }
        public void setage(int Age) { age = Age; }
        public double getheight() { return height; }
        public void setheight(double Height) { height = Height; }
        public double getweight() { return weight; }
        public void setweight(double Weight) { weight = Weight; }
    }
}