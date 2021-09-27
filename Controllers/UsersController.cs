using Microsoft.AspNetCore.Mvc;
using Orderplacement_system.Repositories;
using Orderplacement_system.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Orderplacement_system.UserDtos;

namespace Orderplacement_system.Controllers
{
    // ApiController Gives additional default behaviors
    [ApiController]
    // Defines the route where the HTTP controller will be responding.
    // [controller] Whatever the name of the controller class is will be the route. But if using camel case the first word in the camel case text will be used.
    // EXAMPLE: GET /users
    [Route("[controller]")]
    // ControllerBase turns the class into a controller class.
    public class UsersController : ControllerBase
    {
        private readonly IInMemUsersRepository repository;

        public UsersController(IInMemUsersRepository repository)
        {
            this.repository = repository;
        }

        // When someone goes to /items as get the method beneath is what is going to be ran.
        // GET /users
        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            var items = repository.GetUsers().Select(user => user.AsUserDto());

            return items;
        }
        // Specify how you are gonna treat an extra value
        // We need to add a template where we specify how we are going to treat another route.
        // GET /users/{id}
        [HttpGet("{id}")]
        // Action result allows us to return more than one type from the method.
        // Gets 404 when valid because of not using dependancy injection https://youtu.be/ZXdFisA_hOY?t=2481
        public ActionResult<UserDto> GetUser(Guid id)
        {
            var user = repository.GetUser(id);

            if (user is null) return NotFound();

            return user.AsUserDto();
        }

        // POST /items
        [HttpPost]
        public ActionResult<UserDto> CreateUser(CreateUserDto userDto)
        {
            User user = new()
            {
                Id = Guid.NewGuid(),
                Name = userDto.Name,
                Phone = userDto.Phone,
                Email = userDto.Email,
                City = userDto.City,
                ZipCode = userDto.ZipCode,
                Street = userDto.Street,
                Note = userDto.Note
            };

            repository.CreateUser(user);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id } , user.AsUserDto());
        }

        // PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(Guid id, UpdateUserDto UserDto)
        {
            var existingUser = repository.GetUser(id);

            if (existingUser is null) return NotFound();

            // Keep note if one exist.
            if (UserDto.Note == null && existingUser != null) UserDto.Note = existingUser.Note;

            User updatedUser = existingUser with
            {
                Name = UserDto.Name,
                Phone = UserDto.Phone,
                Email = UserDto.Email,
                City = UserDto.City,
                ZipCode = UserDto.ZipCode,
                Street = UserDto.Street,
                Note = UserDto.Note
            };

            repository.UpdateUser(updatedUser);

            return NoContent();
        }
        
        // DELETE /items/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var existingUser = repository.GetUser(id);

            if (existingUser is null) return NotFound();

            repository.DeleteUser(id);

            return NoContent();
        }
    }
}
