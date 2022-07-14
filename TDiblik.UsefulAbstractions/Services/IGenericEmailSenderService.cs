namespace TDiblik.UsefulAbstractions.Services
{
    public interface IGenericEmailSenderService
    {
        public void SendMail(string[] To, string Subject, string Body);
    }
}
