namespace Csharp.Components.Models{
    public class Server{

        public Server(){
            Random random = new Random();
            int randomNumber = random.Next(0,2);
            isOnline = randomNumber == 0? false : true;
        }

        public int ServerId{get; set;}
        public bool isOnline{get; set;}
        public string? ServerName{get; set;}
        public string? City{get; set;}
    }
}
