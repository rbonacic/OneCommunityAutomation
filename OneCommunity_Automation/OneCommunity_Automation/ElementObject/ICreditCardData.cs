namespace OneCommunity_Automation.ElementObject
{
    public interface ICreditCardData
    {
        string PaymentAmount { get; set; }
        
        int PaymentMethodIndex { get; set; }
        
        string ExpireMonth { get; set; }
        
        string ExpireYear { get; set; }

        string Cvv { get; set; }
        
        string CardHolderFirstName { get; set; }

        string CardHolderLastName { get; set; }

        string VisaCardNumber { get; set; }

        string MasterCardCardNumber { get; set; }

        string AmexCardNumber { get; set; }

        string DiscoverCardNumber { get; set; }
    }
}