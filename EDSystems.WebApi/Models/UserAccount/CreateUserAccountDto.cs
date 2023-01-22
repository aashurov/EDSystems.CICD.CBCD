﻿using AutoMapper;
using EDSystems.Application.Common.Mappings;
using EDSystems.Application.EDSystems.Commands.Accounts.CreateAccount;

namespace EDSystems.WebApi.Models.Account
{
    public class CreateUserAccountDto : IMapWith<CreateUserAccountCommand>
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string UserId { get; set; }
        public int CurrencyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateUserAccountDto, CreateUserAccountCommand>()
                .ForMember(createAccountCommand => createAccountCommand.Name,
                    options => options.MapFrom(createAccountDto => createAccountDto.Name))
                .ForMember(createAccountCommand => createAccountCommand.Number,
                    options => options.MapFrom(createAccountDto => createAccountDto.Number))
                .ForMember(createAccountCommand => createAccountCommand.Balance,
                    options => options.MapFrom(createAccountDto => createAccountDto.Balance))
                .ForMember(createAccountCommand => createAccountCommand.UserId,
                    options => options.MapFrom(createAccountDto => createAccountDto.UserId))
            .ForMember(createAccountCommand => createAccountCommand.CurrencyId,
                    options => options.MapFrom(createAccountDto => createAccountDto.CurrencyId));
        }
    }
}