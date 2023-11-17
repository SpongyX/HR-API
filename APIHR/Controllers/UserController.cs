using APIHR.Data;
using APIHR.Interfaces;
using APIHR.ModelsDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserInterface _userInterface;
        public UserController (IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        [Route("GetUsers")]

        public IActionResult GetUsers()
        {
            var response = _userInterface.FetchAll();
            return Ok(response);
        }
        [HttpPost]
        [Route("AddUser")]

        public IActionResult AddUser(UserDTO userDTO)
        {
               var response = _userInterface.Add(userDTO);
            return Ok(response);
        }
        [HttpDelete]
      

        public IActionResult DeleteUser(int id)
        {
            var response = _userInterface.Delete(id);
            return Ok(response);
        }
        [HttpGet]
        [Route("GetUserById/{id}")]

        public IActionResult GetUserById(int id)
        {
            var response = _userInterface.FetchById(id);
            return Ok(response);
        }
    }
}
