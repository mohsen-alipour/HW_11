using HW_11.infrastructure.DataBase;
using HW_11.Models.Entity;
namespace HW_11.infrastructure.DataAccess
{
    public class FactorRpository
    {
        StoreContext _StoreDB;
        public FactorRpository()
        {
            _StoreDB = new StoreContext();
        }

        public List<FactoQueryModel> GetAllFactor()
        {
          
            var result = (
                from F in _StoreDB._Factor
                join S in _StoreDB._Seller on F.SellerID equals S.ID
                join P in _StoreDB._Producer on F.ProducerID equals P.ID
                join C in _StoreDB.Customer on F.CustomerID equals C.ID
                select new FactoQueryModel
                {
                    NumFactor=F.ID,
                    NameSeller=S.Name,
                   AdressSeller=S.S_Adderss,
                   NameProducter=P.Name,
                   adressProducter=P.P_Adderss,
                   NameCustomer=C.Name,
                   TelCustomer=C.Tel,
                }).ToList();
            return(result);


        }
        public Factor  getfactor(int factorid)
        {
            return _StoreDB._Factor.Where(x => x.ID == factorid).FirstOrDefault();
        }

        public Seller SellerDetail(int id)
        {
          Factor R= getfactor(id);
            var s= _StoreDB._Seller.Where(x => x.ID == R.SellerID).FirstOrDefault();
            return (s);
        }
        public Producer ProducterDetail(int id)
        {
            Factor R = getfactor(id);
            var p = _StoreDB._Producer.Where(x => x.ID == R.ProducerID).FirstOrDefault();
            return (p);
        }
        public Customer CustomererDetail(int id)
        {
            Factor R = getfactor(id);
            var C = _StoreDB.Customer.Where(x => x.ID == R.CustomerID).FirstOrDefault();
            return (C);
        }


    }
}
