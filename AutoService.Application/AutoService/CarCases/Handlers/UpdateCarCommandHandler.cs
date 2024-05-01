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
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, ResponceModel>
    {
        private readonly IAppDbConext _context;
        private readonly UserManager<UserModel> _userManager;

        public UpdateCarCommandHandler(IAppDbConext context, UserManager<UserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ResponceModel> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == request.UserLogin.Email);

            if (user != null)
            {
                var res = await _userManager.CheckPasswordAsync(user, request.UserLogin.Password);
                if (res)
                {
                    var userview = new UserViewModel
                    {
                        UserName = user.Name,
                        Email = user.Email
                    };

                    var car = new CarModel
                    {
                        User = userview,
                        City = request.City,
                        CarYear = request.CarYear,
                        VINcode = request.VINcode,
                        CarNumber = request.CarNumber,
                        ChasisNumber = request.ChasisNumber,
                        Probeg = request.Probeg,
                        CarNumberPlate = request.CarNumberPlate,
                        WheelBrand = request.WheelBrand,
                        CarMass = request.CarMass,
                        FuelType = request.FuelType,
                        BrakeType = request.BrakeType,
                        CarCategory = request.CarCategory,
                        DocumentType = request.DocumentType,
                        Seria = request.Seria
                    };

                    _context.carModels.Update(car);
                    await _context.SaveChangesAsync(cancellationToken);

                    return new ResponceModel
                    {
                        Message = "You succesfully updated properties of your car",
                        StatusCode = 200,
                        IsSuccess = true
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
