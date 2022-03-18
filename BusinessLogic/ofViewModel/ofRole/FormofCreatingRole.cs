namespace BusinessLogic.ofViewModel.ofRole
{
    // 비교를 할 때 HashCode를 이용할 수 있도록 하자.
    // View 단위로 기능 또한 몰아서 관리하는 게 바람직하겠다.
    public enum PossibleRole { Producter, Forwarder, LogisticsAgency, DeliveryAgency}
    public class FormofCreatingRole
    {
        public string NormalizedRole { get; set; }
        public string Role { get; set; }
        public bool ValidateCheck (string Role)
        {
            int InputRoleHashCode = Role.GetHashCode();
            int Producter = PossibleRole.Producter.ToString().GetHashCode();
            int Forwarder = PossibleRole.Forwarder.ToString().GetHashCode();
            int LogisticsAgency = PossibleRole.LogisticsAgency.ToString().GetHashCode();
            int DeliveryAgency = PossibleRole.DeliveryAgency.ToString().GetHashCode();
            if (InputRoleHashCode == Producter || InputRoleHashCode == Forwarder || InputRoleHashCode == LogisticsAgency || InputRoleHashCode == DeliveryAgency)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
