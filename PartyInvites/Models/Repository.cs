using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> lstGuestResponses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> enumerableResponses
        {
            get
            {
                return lstGuestResponses;
            }
        }

        public static void AddResponses(GuestResponse guestResponse)
        {
            lstGuestResponses.Add(guestResponse);
        }
    }
}
