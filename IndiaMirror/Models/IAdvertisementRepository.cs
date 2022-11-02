using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMirror.Models
{
    public interface IAdvertisementRepository
    {
        Advertisement GetAdvertisement(int Id);
        IEnumerable<Advertisement> GetAdvertisements(String catagory);

        IEnumerable<Advertisement> GetAdvertisements_user(int userId);

        IEnumerable<Advertisement> GetAdvertisements_admin(String status);
        Advertisement Add(Advertisement Advertisement);
        Advertisement Update(Advertisement AdvertisementChanges);

        Advertisement Delete(int Id);
    }
}
