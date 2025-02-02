namespace OrakYazilimLib.MvcPattern
{
    public class AbsModal
    {
        protected string connProfile;

        public AbsModal(string connProfile) {
            this.connProfile = connProfile;
        }
    }
}