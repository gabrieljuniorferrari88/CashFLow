namespace CashFlow.Domain.Repositories.User;

public interface IUserReadOnlyRepository
{
    Task<bool> ExistActiveUserWhiteEmail(string email);
    Task<Entities.User?> GetUserByEmail(string email);
}