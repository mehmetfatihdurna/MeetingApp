namespace MeetingApp.Models{
    public class UserInfo{

        public int Id;

        private static int id = 0;

        public UserInfo(){
            this.Id = id;
            id+=1;
        }


        public string? Name{get;set;}

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public bool WillAttend { get; set; }
        
    }
}