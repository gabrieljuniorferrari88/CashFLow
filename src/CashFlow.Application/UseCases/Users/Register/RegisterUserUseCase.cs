using AutoMapper;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Security.Cryptography;

namespace CashFlow.Application.UseCases.Users.Register;

public class RegisterUserUseCase : IRegisterUserUseCase
{
    private readonly IMapper _mapper;
    private readonly IPasswordEncripter _passwordEncripter;

    public RegisterUserUseCase(
        IMapper mapper,
        IPasswordEncripter passwordEncripter
        )
    {
        _mapper = mapper;
        _passwordEncripter = passwordEncripter;
    }
    public async Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson request)
    {
        Validate(request);

        var user = _mapper.Map<User>(request);
        user.Password = _passwordEncripter.Encrypt(request.Password);

        return new ResponseRegisteredUserJson
        {
            Name = user.Name,
        };
    }

    public void Validate(RequestRegisterUserJson request)
    {
        var result = new RegisterUserValidator().Validate(request);
    }
}