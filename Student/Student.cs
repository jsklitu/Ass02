using System;

namespace Student
{
    public class StudentClass
    {
        public int ID{get; init;}

        public string GivenName {get; set;}
        public string Surname {get; set;}

        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime GraduationDate {get; set;}

        private StatusEnum _Status;
        public StatusEnum Status{
            get => _Status;
            init {
                var now = DateTime.Now;
                if(StartDate <= now && EndDate >= now){
                    Status = StatusEnum.ACTIVE;}
                else if(GraduationDate == EndDate){
                    Status = StatusEnum.GRADUATED;
                }else if(StartDate > now){
                    Status = StatusEnum.NEW;
                }else{
                    Status = StatusEnum.DROPOUT;
                }
            }
        }

        public enum StatusEnum
            {NEW, ACTIVE, DROPOUT, GRADUATED}
        
        public static void Main(string[] args){

        }


        public override String ToString(){
            return "Student ID: " + ID + "." + Environment.NewLine + 
                    "Student name: " + GivenName + " " + Surname + "." + Environment.NewLine +
                    "Status: " + Status + ".";
            
        }

    }
    
    
    
    

   
}
