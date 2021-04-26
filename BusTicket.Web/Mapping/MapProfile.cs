using AutoMapper;
using BusTicket.Core.Models;
using BusTicket.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Web.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<UserType, UserTypeDto>();
            CreateMap<UserTypeDto, UserType>();

            CreateMap<Ticket, TicketDto>();
            CreateMap<TicketDto, Ticket>();

            CreateMap<Route, RouteDto>();
            CreateMap<RouteDto, Route>();

            CreateMap<Location, LocationDto>();
            CreateMap<LocationDto, Location>();
        }
    }
}
