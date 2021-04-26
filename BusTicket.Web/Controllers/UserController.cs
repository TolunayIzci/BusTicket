using AutoMapper;
using BusTicket.Core.Models;
using BusTicket.Core.Services;
using BusTicket.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusTicket.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var GetAll = await _userService.ListAsync(x => x.UserTypeId == 1);


            return View(_mapper.Map<IEnumerable<UserDto>>(GetAll));
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            await _userService.AddAsync(_mapper.Map<User>(userDto));
            return RedirectToAction("Index");

        }
    }
}
