using CashFlow.Domain.Enums;

namespace CashFlow.Domain.Extensions;

public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourcePaymentTypeMessages.CASH,
            PaymentType.CreditCard => ResourcePaymentTypeMessages.CREDIT_CARD,
            PaymentType.DebitCard => ResourcePaymentTypeMessages.DEBIT_CARD,
            PaymentType.ElectronicTransfer => ResourcePaymentTypeMessages.ELETRONIC_TRANSFER,
            _ => string.Empty
        };
    }
}