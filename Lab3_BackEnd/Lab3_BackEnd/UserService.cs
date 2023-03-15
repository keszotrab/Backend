namespace Lab3_BackEnd
{
    public class  UserService
    {
        Dictionary<string, string> Users = new Dictionary<string, string>();


        public void Add(string connectionId, string username) 
        {

            Users.Add(username, connectionId);
        }
        
        public void RemoveByName(string username) 
        {
            Users.Remove(username);
        }

        public string GetConnectioIdByName(string username) 
        {
            return Users[username];
        }
        public IEnumerable<(string ConnectionId, string Username)> GetAll() 
        {
            return Users.Select(e => new {ConnectionId = e.Value, Username = e.Key }).AsEnumerable();
            
        }

    }
}
