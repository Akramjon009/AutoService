using AutoService.Application.Abstractions;
using AutoService.Application.AutoService.CarCases.Commands;
using AutoService.Domain.Entities.Models;
using AutoService.Domain.Entities.Models.CarModels;
using AutoService.Domain.Entities.Models.UserModels;
using AutoService.Domain.Entities.ViewModels.CarViewModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.AutoService.CarCases.Handlers
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, ResponceModel>
    {
        private readonly IAppDbConext _context;
        private readonly UserManager<UserModel> _userManager;

        public DeleteCarCommandHandler(IAppDbConext context, UserManager<UserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ResponceModel> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == request.UserLogin.Email);

            if (user != null)
            {
                var res = await _userManager.CheckPasswordAsync(user, request.UserLogin.Password);
                if (res)
                {
                    var car = await _context.carModels.FirstOrDefaultAsync(x => x.User.Email == request.UserLogin.Email);

                    if (car != null)
                    {

                        _context.carModels.Remove(car);
                        await _context.SaveChangesAsync(cancellationToken);

                        return new ResponceModel
                        {
                            Message = "You succesfully removed your car",
                            StatusCode = 200,
                            IsSuccess = true
                        };
                    }

                    return new ResponceModel
                    {
                        Message = "You haven't registered your car yet!",
                        StatusCode = 401
                    };
                }

                return new ResponceModel
                {
                    Message = "Incorrect password",
                    StatusCode = 401
                };
            }

            return new ResponceModel
            {
                Message = "Email not found! Please register or if you have an account log in!!!",
                StatusCode = 404
            };
        }
    }
}
