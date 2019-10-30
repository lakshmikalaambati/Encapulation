namespace Encapulation
{
    public class PersonHandler
    {
                
        //This method will create new person
        public Person createperson(string fname, string lname, int age,double height, double weight)
        {
            var newperson = new Person();

            newperson.setfname(fname);
            newperson.setlname(lname);
            newperson.setage(age);
            newperson.setweight(weight);
            newperson.setheight(height);

            return newperson;
        }

        //This method will set the age of the person
        public void SetAge(Person pers, int age)
        {
            pers.setage(age);

        }

        //This method will set the height of the person
        public void Setheight(Person pers, double height)
        {
            pers.setheight(height);

        }
       
        //This method will set the weight of the person
        public void Setweight(Person pers, double weight)
        {
            pers.setweight(weight);

        }

        //This method will update Height and Weight of the Person
        public void UpdateHeightWeight(Person pers ,double hei ,double wei )
        {
            pers.setweight(wei);
            pers.setheight(hei);

        }




    }
}