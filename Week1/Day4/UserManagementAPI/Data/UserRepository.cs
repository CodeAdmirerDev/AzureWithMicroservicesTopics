using UserManagementAPI.Models;

namespace UserManagementAPI.Data
{
    public class UserRepository
    {
        private List<User> _users;

        public UserRepository() {


            _users = new List<User>
        {
            new User { Id = 1, Name = "Suri", Email = "suri@gmail.com" },
            new User { Id = 2, Name = "Mouni", Email = "mouni@gmail.com" }
        };
        }

        public List<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = GetById(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }
    }
}
