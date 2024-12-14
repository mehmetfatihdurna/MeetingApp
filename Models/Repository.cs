namespace MeetingApp.Models{
    public static class Repository{
        private static List<UserInfo> _users = new();

        static Repository(){
            _users.Add(new UserInfo{
                Name="Ahmet",
                Phone="05511735420",
                Email="abc@gmail.com",
                WillAttend=true
            });

             _users.Add(new UserInfo{
                Name="Ayşe",
                Phone="05671839770",
                Email="ayse@hotmail.com",
                WillAttend=true
            });

             _users.Add(new UserInfo{
                Name="Veli",
                Phone="05378332453",
                Email="velisefa@yahoo.com",
                WillAttend=true
            });
        }

        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            _users.Add(user); 
        }

        public static UserInfo? GetUserById(int id){
            return _users.FirstOrDefault(user=>user.Id==id);
        }
    }
}