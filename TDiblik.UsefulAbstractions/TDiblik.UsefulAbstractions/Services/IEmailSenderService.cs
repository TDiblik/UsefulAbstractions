namespace TDiblik.UsefulAbstractions.Services
{
    public interface IEmailSenderService
    {
        public void SendMail(string[] To, string Subject, string Body);
    }
}
