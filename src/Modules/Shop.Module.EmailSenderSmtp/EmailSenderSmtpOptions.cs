namespace Shop.Module.EmailSenderSmtp
{
    public class EmailSenderSmtpOptions
    {
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpHost { get; set; } = "smtp.mxhichina.com";
        public int SmtpPort { get; set; } = 587;
    }
}
