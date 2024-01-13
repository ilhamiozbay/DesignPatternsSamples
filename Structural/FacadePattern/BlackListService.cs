namespace FacadePattern
{
    // Kara liste ile ilgili işlemlerin yapıldığı sınıf
    class BlackListService
    {
        public bool CheckIfTheEmployeeIsInTheBlackList(Customer customer)
        {
            // Müşterinin kara listede olup olmadığının kontrolünün yapıldığı yer.
            // Kara listede ise false, değilse true dönmekte olduğunu var sayalım.
            // Burada veri tabanı kodları ya da harici bir servis ile iletişim sağlanabilir.
            // Default olarak true döndürdük.
            if (customer?.FirstName.Contains("ilhami")==true)
            {
                return false;
            }

            return true;
        }
    }
}
