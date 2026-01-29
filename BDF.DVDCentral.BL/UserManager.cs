using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;

namespace BDF.DVDCentral.BL
{
    public class LoginFailureException : Exception
    {
        public LoginFailureException() : base("Cannot log in with these credentials.")
        {
        }

        public LoginFailureException(string message) : base(message)
        {
        }
    }

    public class UserManager : GenericManager<tblUser>
    {
        public UserManager(DbContextOptions<DVDCentralEntities> options, ILogger logger) : base(options, logger) { }
        public UserManager(DbContextOptions<DVDCentralEntities> options) : base(options) { }
        public static string GetHash(string password)
        {
            using (var hasher = SHA1.Create())
            {
                var hashbytes = Encoding.UTF8.GetBytes(password);
                return Convert.ToBase64String(hasher.ComputeHash(hashbytes));
            }
        }

        public async Task<Guid> InsertAsync(User user, bool rollback = false)
        {
            try
            {
                tblUser row = Map<User, tblUser>(user);
                return await base.InsertAsync(row,
                                              e => e.UserId == user.UserId,
                                              rollback);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<int> UpdateAsync(User user, bool rollback = false)
        {
            try
            {
                tblUser row = Map<User, tblUser>(user);
                return await base.UpdateAsync(row,
                                              e => e.UserId == user.UserId,
                                              rollback);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<List<User>> LoadAsync()
        {
            try
            {
                List<User> rows = new List<User>();
                (await base.LoadAsync())
                    .ForEach(e => rows.Add(Map<tblUser, User>(e)));
                return rows;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Login(User user)
        {
            try
            {
                if (!string.IsNullOrEmpty(user.UserId))
                {
                    if (!string.IsNullOrEmpty(user.Password))
                    {
                        using (DVDCentralEntities dc = new DVDCentralEntities(options))
                        {
                            tblUser tblUser = dc.tblUsers.FirstOrDefault(u => u.UserId == user.UserId)!;
                            if (tblUser != null)
                            {
                                if (tblUser.Password == GetHash(user.Password))
                                {
                                    // Login successful
                                    user.Id = tblUser.Id;
                                    user.FirstName = tblUser.FirstName;
                                    user.LastName = tblUser.LastName;
                                    return true;
                                }
                                else
                                {
                                    throw new LoginFailureException();
                                }
                            }
                            else
                            {
                                throw new LoginFailureException("UserId was not found.");
                            }
                        }
                    }
                    else
                    {
                        throw new LoginFailureException("Password was not entered.");
                    }
                }
                else
                {
                    throw new LoginFailureException("UserId was not entered.");
                }
            }
            catch (LoginFailureException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
