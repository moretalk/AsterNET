namespace AsterNET.Manager.Action
{
    public class SipNotifyAction : ManagerAction
    {
        /// <summary>
        ///Sip Notify.
        /// </summary>
        public SipNotifyAction()
        {

        }

        /// <summary>
        ///     Sip Notify.
        /// </summary>
        /// <param name="channel">Transferer's channel.</param>
        /// <param name="variable">Notify Variable</param>
        public SipNotifyAction(string channel, string variable)
        {
            Channel = channel;
            Variable = variable;
        }

        public override string Action
        {
            get { return "SIPnotify"; }
        }

        /// <summary>
        ///     Sip Notify Destination channel.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        ///     Sip Notify Variable name=
        /// </summary>
        public string Variable { get; set; }
    }
}
