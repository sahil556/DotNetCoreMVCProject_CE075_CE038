using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndiaMirror.Models
{
    public class SQLAdvertisementRepository : IAdvertisementRepository
    {
        private readonly AppDbContext context;
        public SQLAdvertisementRepository(AppDbContext context)
        {
            this.context = context;
        }
        Advertisement IAdvertisementRepository.Add(Advertisement Advertisement)
        {
            context.Advertisement.Add(Advertisement);
            context.SaveChanges();
            return Advertisement;
        }

        Advertisement IAdvertisementRepository.Delete(int Id)
        {
            Advertisement ad = context.Advertisement.Find(Id);
            if (ad != null)
            {
                context.Advertisement.Remove(ad);
                context.SaveChanges();
            }
            return ad;
        }

        Advertisement IAdvertisementRepository.GetAdvertisement(int Id)
        {
            return context.Advertisement.FirstOrDefault(m => m.Id == Id);
        }

        IEnumerable<Advertisement> IAdvertisementRepository.GetAdvertisements(string category)
        {
            return context.Advertisement.Where(m => m.category == category);
        }

        IEnumerable<Advertisement> IAdvertisementRepository.GetAdvertisements_admin(string status)
        {
            return context.Advertisement.Where(m => m.status == status);
        }

        IEnumerable<Advertisement> IAdvertisementRepository.GetAdvertisements_user(int userId)
        {
            return context.Advertisement.Where(m => m.user_id == userId);
        }

        Advertisement IAdvertisementRepository.Update(Advertisement AdvertisementChanges)
        {
            var Advertisement = context.Advertisement.Attach(AdvertisementChanges);
            Advertisement.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return AdvertisementChanges;
        }
    }
}
