using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using TravelDeskApi.Context;
using TravelDeskApi.IRepo;
using TravelDeskApi.Models;

namespace TravelDeskApi.Repo
{
    public class TravelRequestRepository:ITravelRequestRepository
    {
        TravelDbContext _travelDbContext;
        public TravelRequestRepository(TravelDbContext travelDbContext)
        {
            _travelDbContext = travelDbContext;
        }

        public TravelRequest ADDTravelRequest(TravelRequest travelRequest)
        {
            _travelDbContext.TravelRequests.Add(travelRequest);
            _travelDbContext.SaveChanges();
            return travelRequest;
        }

        public TravelRequest DELETEDTravelRequest(int trvalId)
        {
            TravelRequest trvl = GetTravelRequestById(trvalId);
            if (trvl != null)
            {
                _travelDbContext.Remove(trvl);
                _travelDbContext.SaveChanges();
                return trvl;
            }
            else
                return trvl = null;
        }

        public List<TravelRequest> GetTravelRequest(TravelRequest travelRequest)
        {
            return _travelDbContext.TravelRequests.ToList();
        }

        public TravelRequest GetTravelRequestById(int id)
        {
            var trl = _travelDbContext.TravelRequests.FirstOrDefault(x => x.Id == id);
            return trl;
        }

        public TravelRequest UpdateTravelRequest(int Id,TravelRequest travelRequest)
        {
            TravelRequest tbt = GetTravelRequestById(Id);
            if (tbt != null)
            {
                tbt.ReasonForTravel = travelRequest.ReasonForTravel;
                _travelDbContext.SaveChanges();
                return tbt;
            }
            else
                return tbt = null;
        }
    }
}
