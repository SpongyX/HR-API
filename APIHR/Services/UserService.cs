using APIHR.Data;
using APIHR.Helpers;
using APIHR.Interfaces;
using APIHR.ModelsDto;

namespace APIHR.Services
{
    public class UserService : IUserInterface
    {

        private readonly DbhrContext _bhrContext;
        public UserService(DbhrContext bhrContext)

        {
            _bhrContext = bhrContext;
        }

        public ResponseRequest Add(UserDTO entity)
        {
            try
            {
                var newUser = new User
                {
                    
                    Name = entity.Name,
                    Description = entity.Description,
                    PositionId = entity.PositionId,
                    DepartmentId = entity.DepartmentId,
                    EnumCode = entity.EnumCode,
                    Email = entity.Email,
                    Mobile = entity.Mobile,
                    Address = entity.Address,
                    IsActive = true,
                    StartDate = DateOnly.FromDateTime(DateTime.Now),
                    EndDate = DateOnly.FromDateTime(DateTime.Now)

                };
              if (newUser == null)
                {
                    return ResponseRequest.PerformError("faild");
                }
                _bhrContext.Add(newUser);
                _bhrContext.SaveChanges();
                return ResponseRequest.PerformSuccess();
            }
            catch (Exception ex)
            {
                return ResponseRequest.PerformError(ex.Message);
            }
        }

        public ResponseRequest Delete(int id)
        {
            try
            {
                var userExist = _bhrContext.Users.Where(x => x.UserCode == id).FirstOrDefault();
                if (userExist == null)
                {
                    return ResponseRequest.PerformError("User not exist");
                }
                    _bhrContext.Remove(userExist);
                    _bhrContext.SaveChanges();
                    return ResponseRequest.PerformSuccess();                 
            }
            catch (Exception ex)
            {
                return ResponseRequest.PerformError(ex.Message);
            }
        }

        public ResponseRequest FetchAll()
        {
            try
            {
                var user = _bhrContext.Users.ToList();
                if (user == null )
                {
                    return ResponseRequest.PerformError("User not found");
                }
                return ResponseRequest.PerformSuccess(user);
            }
            catch (Exception ex)
            {

                return ResponseRequest.PerformError(ex.Message);
            }
        }

        public ResponseRequest FetchById(int id)
        {
            try
            {
                var userById = _bhrContext.Users.Where(x => x.UserCode == id).FirstOrDefault();
                if(userById == null)
                {
                    return ResponseRequest.PerformError("User not found");  

                }
                return ResponseRequest.PerformSuccess(userById);
            }
            catch (Exception ex)
            {

                return ResponseRequest.PerformError(ex.Message);
            }
        }

        public ResponseRequest IsExisst(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseRequest Save()
        {
            throw new NotImplementedException();
        }

        public ResponseRequest Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
