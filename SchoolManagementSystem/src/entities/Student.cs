    public class Student
    {

        //#region

        int rollNo;
        public String name;
        String address;

        //#endregion


        public Student(int id, String name, String address)
        {
            this.rollNo = id;
            this.name = name;
            this.address = address;
        }

        public int getRollNo()
        {
            return rollNo;
        }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }

        public void setRollNo(int rollNo)
        {
            this.rollNo = rollNo;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

    }
