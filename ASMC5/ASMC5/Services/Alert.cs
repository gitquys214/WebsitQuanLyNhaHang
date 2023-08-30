namespace ASMC5.Services
{
    public enum Alerts
    {
        Success,
        Danger
    }
    public class Alert
    {
        public static string ShowAlert(Alerts alerts, string message)
        {
            string alertElement = null;

            switch (alerts)
            {
                case Alerts.Success:
                    alertElement =
                        @$"<div class='alert alert-success'role='alert'>
                               { message}
                         </ div > ";
                    break;
                case Alerts.Danger:
                    alertElement =
                         @$"<div class='alert alert-danger'role = 'alert' >
                               { message}
                         </ div > ";
                    break;
                default:
                    break;
            }
            return alertElement;
        }
    }
}
